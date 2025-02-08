const mysql = require('mysql2/promise');
const fs = require('fs');
const path = require('path');
require('dotenv').config(); 
// Database Configuration
const dbConfig = {
    host: process.env.host,
    port: process.env.port,
    user: process.env.user,
    password: process.env.password,
    database: process.env.database
};

// Map MySQL data types to C# types
const typeMapping = {
    'int': 'int',
    'bigint': 'ulong',
    'tinyint': 'bool',
    'smallint': 'short',
    'mediumint': 'int',
    'decimal': 'decimal',
    'float': 'float',
    'double': 'double',
    'char': 'string',
    'varchar': 'string',
    'text': 'string',
    'longtext': 'string',
    'date': 'DateTime',
    'datetime': 'DateTime',
    'timestamp': 'DateTime',
    'time': 'TimeSpan'
};

function getDefaultValue(csharpType) {
    switch (csharpType) {
        case 'string':
            return 'string.Empty';
        case 'int':
        case 'long':
        case 'ulong':
        case 'float':
        case 'double':
            return '0';
        case 'bool':
            return 'false';
        default:
            return 'null';
    }
}
// Root output directory
const outputDir = path.join(__dirname, 'generated');

// Create folders if they don't exist
const folders = ['Models', 'Repositories', 'Interfaces', 'Services', 'Controllers', 'DependencyResolver'];
folders.forEach(folder => {
    const dir = path.join(outputDir, folder);
    if (!fs.existsSync(dir)) {
        fs.mkdirSync(dir, { recursive: true });
    }
});

// Convert snake_case to PascalCase
const toPascalCase = (str) => {
    if (typeof str !== 'string') {
        console.log(str)
        throw new TypeError('Input must be a string');
    }
    return str.replace(/(^|_)([a-z])/g, (_, __, letter) => letter.toUpperCase());
};

// Generate C# classes
async function generateCSharpClasses() {
    const connection = await mysql.createConnection(dbConfig);

    const [tables] = await connection.execute("SHOW TABLES");
    const tableNames = tables.map(row => Object.values(row)[0]);
    let repositoryRegistrations = '';
    let serviceRegistrations = '';
    let mapperReg = "";
    for (const tableName of tableNames) {
        const [columns] = await connection.execute(`DESCRIBE \`${tableName}\``);
        const [foreignKeys] = await connection.execute(`SELECT COLUMN_NAME, REFERENCED_TABLE_NAME, REFERENCED_COLUMN_NAME 
         FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
         WHERE TABLE_NAME = ? 
         AND TABLE_SCHEMA = DATABASE() 
         AND REFERENCED_TABLE_NAME IS NOT NULL;`,
            [tableName]
        )

        const className = toPascalCase(tableName);
        console.log(`Generating Model for ${className}.....`)
        // Generate Model
        generateModel(className, tableName, columns, foreignKeys);
        console.log(`success`)
        console.log(`Generating Repository for ${className}.....`)

        // Generate Repository Interface & Implementation
        generateRepositoryFiles(className);
        repositoryRegistrations += `            services.AddScoped<I${className}Repository, ${className}Repository>();\n`;
        console.log(`success`)
        console.log(`Generating Service for ${className}.....`)

        // Generate Service Interface & Implementation
        generateServiceFiles(className);
        serviceRegistrations += `            services.AddScoped<I${className}Service, ${className}Service>();\n`;
        console.log(`success`)
        // Generate Controller
        console.log(`Generating Controller for ${className}.....`)

        generateController(className);

        console.log(`success`)
        
        console.log(`Generating Mapper for ${className}.....`)

        generateMapper(className);
        mapperReg += `services.AddAutoMapper(typeof(${className}).Assembly);\n`;

        console.log(`success`)
    }
    console.log(`Generating Repository registration.....`)
    // Generate Repository Dependency Resolver
    generateRepositoryResolver(repositoryRegistrations);
    console.log(`success`) 
    console.log(`Generating Repository registration.....`)
    // Generate Service Dependency Resolver
    console.log(`Generating mapper profile registrator .....`)
    generateMapperProfileRegistration(mapperReg)
    console.log("success");
    generateServiceResolver(serviceRegistrations);
    console.log(`success`) 
    connection.end();
}

// Generate Model Class
function generateModel(className, tableName, columns, foreignKeys) {
    let classCode = `using System;\nusing System.Collections.Generic;\nusing System.ComponentModel.DataAnnotations.Schema;\nusing AdminPanel.ModelsAndRepository.Interfaces;\n\n`;
    classCode += `[Table("${tableName}")]\n`;
    classCode += `namespace AdminPanel.ModelsAndRepository.Models { \n`
    classCode += `public class ${className} : IEntity {\n`;

    let navigationProperties = "";

    for (const column of columns) {
        const csharpType = typeMapping[column.Type.split('(')[0]] || 'string';
        const propertyName = toPascalCase(column.Field);
        classCode += `    [Column("${propertyName}")] public ${csharpType} ${toPascalCase(propertyName)} { get; set; }\n`;

        if (column.PrimaryKey) {
            classCode += `    [Key]\n`;
        }

        // Handle Unique Key
        if (column.Unique) {
            classCode += `    [Index("${propertyName}_Unique", IsUnique = true)]\n`;
        }

        // Add the property
        classCode += `    [Column("${column.Field}")] public ${csharpType} ${propertyName} { get; set; }\n`;

        // Handle foreign keys
        if (foreignKeys[column.Field]) {
            const relatedClass = toPascalCase(foreignKeys[column.Field]);
            navigationProperties += `    public ${relatedClass}? ${relatedClass} { get; set; }\n`;
        }
    }

    // Many-to-Many Relationship Handling
    if (foreignKeys.manyToMany) {
        for (const fk of foreignKeys.manyToMany) {
            const relatedClass = toPascalCase(fk);
            navigationProperties += `    public List<${relatedClass}> ${relatedClass}s { get; set; } = new();\n`;
        }
    }

    classCode += `\n${navigationProperties}}\n }\n`;

    saveFile('Models', `${className}.cs`, classCode);
    generateDTOs(className, tableName, columns, foreignKeys);
}
// Generate Repository Interface & Implementation
function generateRepositoryFiles(className) {
    const repoInterface = `using AdminPanel.ModelsAndRepository.Models;\n\nnamespace AdminPanel.ModelsAndRepository.Interfaces {\n    public interface I${className}Repository : IGenericRepository<${className}> {}\n}`;
    saveFile('Interfaces', `I${className}Repository.cs`, repoInterface);

    const repoClass = `using System.Data;\nusing AdminPanel.ModelsAndRepository.Interfaces;\nusing AdminPanel.ModelsAndRepository.Models;\n\nnamespace AdminPanel.ModelsAndRepository.Repositories {\n    public class ${className}Repository : GenericRepository<${className}>, I${className}Repository {\n        public ${className}Repository(IDbConnection dbConnection) : base(dbConnection) {}\n    }\n}`;
    saveFile('Repositories', `${className}Repository.cs`, repoClass);
}

// Generate Service Interface & Implementation
function generateServiceFiles(className) {
    const serviceInterface = `using AdminPanel.ModelsAndRepository.Models;\n\nnamespace AdminPanel.Service.Interfaces {\n    public interface I${className}Service : ICrudService<${className}> {}\n}`;
    saveFile('Interfaces', `I${className}Service.cs`, serviceInterface);

    const serviceClass = `using AdminPanel.ModelsAndRepository.Models;\nusing AdminPanel.ModelsAndRepository.Interfaces;\nusing AdminPanel.Service.Interfaces;\n\nnamespace AdminPanel.Service.Services {\n    public class ${className}Service : CrudService<${className}>, I${className}Service {\n        public ${className}Service(I${className}Repository repository) : base(repository) {}\n    }\n}`;
    saveFile('Services', `${className}Service.cs`, serviceClass);
}

// Generate Controller
function generateController(className) {
    const lowercaseClassName = className.charAt(0).toLowerCase() + className.slice(1); // e.g., "Person" -> "person"

    const content = `using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class ${className}Controller : ControllerBase {
        private readonly I${className}Service _service;
        private readonly IMapper _mapper;

        public ${className}Controller(I${className}Service service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> Create${className}([FromBody] ${className}CreateDto ${lowercaseClassName}CreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<${className}>(${lowercaseClassName}CreateDto));
                var displayDto = _mapper.Map<${className}DisplayDto>(entity);
                return Created(nameof(Create${className}), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] ${className}GetDto ${lowercaseClassName}GetDto) {
            try {
                var entity = await _service.GetAsync(${lowercaseClassName}GetDto.Id);
                if (entity == null) {
                    return NotFound("${className} with Id " + ${lowercaseClassName}GetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<${className}DisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update${className}Async([FromBody] ${className}UpdateDto ${lowercaseClassName}UpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(${lowercaseClassName}UpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("${className} with Id " + ${lowercaseClassName}UpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<${className}>(${lowercaseClassName}UpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete${className}Async([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("${className} with Id " + id + " not found.");
                }
                await _service.DeleteAsync(existingEntity);
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("list")]
        public async Task<IActionResult> List([FromBody] QueryParameters? queryParams) {
            try {
                var entities = await _service.ListAsync(queryParams);
                var displayDtos = _mapper.Map<IEnumerable<${className}DisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}`;

    saveFile('Api/Controllers', `${className}Controller.cs`, content);
}

// Generate Repository Dependency Resolver
function generateRepositoryResolver(repositoryRegistrations) {
    const repoResolver = `using Microsoft.Extensions.DependencyInjection;\nusing AdminPanel.ModelsAndRepository.Interfaces;\nusing AdminPanel.ModelsAndRepository.Repositories;\n\nnamespace AdminPanel.ModelsAndRepository.DependencyResolver {\n    public static class Repositories {\n        public static IServiceCollection AddRepositories(this IServiceCollection services) {\n            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));\n${repositoryRegistrations}            return services;\n        }\n    }\n}`;
    saveFile('DependencyResolver', `Repositories.cs`, repoResolver);
}

// Generate Service Dependency Resolver
function generateServiceResolver(serviceRegistrations) {
    const serviceResolver = `using Microsoft.Extensions.DependencyInjection;\nusing AdminPanel.Service.Interfaces;\nusing AdminPanel.Service.Services;\n\nnamespace AdminPanel.Service.DependencyResolver {\n    public static class Services {\n        public static IServiceCollection AddServices(this IServiceCollection services) {\n            services.AddScoped(typeof(ICrudService<>), typeof(CrudService<>));\n${serviceRegistrations}            return services;\n        }\n    }\n}`;
    saveFile('DependencyResolver', `Services.cs`, serviceResolver);
}

function generateDTOs(className, tableName, columns, foreignKeys) {
    const dtos = {
        [`${className}CreateDto.cs`]: (function () {
            let dto = `using System.ComponentModel.DataAnnotations;\nnamespace AdminPanel.Api.DTOs {\n`;
            dto += `    public class ${className}CreateDto : IDto {\n`;
            for (const column of columns) {
                if (column.Field.toLowerCase() !== 'id') {
                    const csharpType = typeMapping[column.Type.split('(')[0]] || 'string';
                    dto += `        public ${csharpType} ${toPascalCase(column.Field)} { get; set; } = ${getDefaultValue(csharpType)};\n`;
                }
            }
            for (const fk in foreignKeys) {
                dto += `        public ulong ${toPascalCase(fk)}Id { get; set; }\n`;
            }
            dto += `    }\n}`;
            return dto;
        })(),

        [`${className}DisplayDto.cs`]: (function () {
            let dto = `using System.ComponentModel.DataAnnotations;\nnamespace AdminPanel.Api.DTOs {\n`;
            dto += `    public class ${className}DisplayDto : IDto {\n`;
            for (const column of columns) {
                const csharpType = typeMapping[column.Type.split('(')[0]] || 'string';
                dto += `        public ${csharpType} ${toPascalCase(column.Field)} { get; set; } = ${getDefaultValue(csharpType)};\n`;
            }
            for (const fk in foreignKeys) {
                let foreignKey = foreignKeys[fk];

                // If foreignKey is an object, extract a relevant property (e.g., COLUMN_NAME)
                if (typeof foreignKey === 'object' && foreignKey !== null) {
                    foreignKey = foreignKey.COLUMN_NAME || ''; // Default to empty string if no COLUMN_NAME
                }

                dto += `        public ${toPascalCase(foreignKey)}DisplayDto? ${toPascalCase(foreignKey)} { get; set; }\n`;
            }
            dto += `    }\n}`;
            return dto;
        })(),

        [`${className}GetDto.cs`]: `using System.ComponentModel.DataAnnotations;\nnamespace AdminPanel.Api.DTOs {\n    public class ${className}GetDto : IDto {\n        public ulong Id { get; set; }\n    }\n}`,

        [`${className}UpdateDto.cs`]: (function () {
            let dto = `using System.ComponentModel.DataAnnotations;\nnamespace AdminPanel.Api.DTOs {\n`;
            dto += `    public class ${className}UpdateDto : IDto {\n`;
            for (const column of columns) {
                const csharpType = typeMapping[column.Type.split('(')[0]] || 'string';
                dto += `        public ${csharpType} ${toPascalCase(column.Field)} { get; set; } = ${getDefaultValue(csharpType)};\n`;
            }
            for (const fk in foreignKeys) {
                dto += `        public ulong ${toPascalCase(fk)}Id { get; set; }\n`;
            }
            dto += `    }\n}`;
            return dto;
        })(),

        [`${className}DeleteDto.cs`]: (function () {
            let dto = `using System.ComponentModel.DataAnnotations;\nnamespace AdminPanel.Api.DTOs {\n`;
            dto += `    public class ${className}DeleteDto : IDto {\n`;
            dto += `        public ulong Id { get; set; }\n`;
            dto += `    }\n}`;
            return dto;
        })(),
    };

    for (const [filename, content] of Object.entries(dtos)) {
        saveFile('Api/DTOs', filename, content);
    }
}


function generateMapper(className) {
    const content = `using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class ${className}Mapper : Profile {
        public ${className}Mapper() {
            CreateMap<${className}, ${className}DisplayDto>();
            CreateMap<${className}CreateDto, ${className}>();
            CreateMap<${className}UpdateDto, ${className}>();
            CreateMap<${className}GetDto, ${className}>();
        }
    }
}`;
    saveFile('Api/Mappers', `${className}Mapper.cs`, content);
}

function generateMapperProfileRegistration(mapperReg) {

    const content = `using AdminPanel.Api.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace AdminPanel.Api.DependencyResolver {
    public static class MapperConfiguration {
        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services) {
            ${mapperReg}
            return services;
        }
    }
}`;
    saveFile('Api/DependencyResolver', 'MapperConfiguration.cs', content);
}



// Save files in corresponding folders
function saveFile(folder, fileName, content) {
    const filePath = path.join(outputDir, folder, fileName);

    // Ensure the parent directory exists
    const dirPath = path.dirname(filePath);  // Get the directory path from filePath
    if (!fs.existsSync(dirPath)) {
        fs.mkdirSync(dirPath, { recursive: true });
    }

    // Check if the path exists and is a directory, delete it if so
    if (fs.existsSync(filePath)) {
        const stats = fs.lstatSync(filePath);
        if (stats.isDirectory()) {
            // Remove the directory before writing the file
            fs.rmdirSync(filePath, { recursive: true });
        }
    }

    // Write the file
    fs.writeFileSync(filePath, content);
}
// Run the generator
generateCSharpClasses().catch(console.error);