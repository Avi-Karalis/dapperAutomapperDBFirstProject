dotnet new sln --name (name)

dotnet new classlib -n AdminPanel.ModelsAndRepository --framework net8.0 
dotnet new classlib -n AdminPanel.Service --framework net8.0
dotnet new webapi -n AdminPanel.Api --framework net8.0

dotnet sln add AdminPanel.ModelsAndRepository
dotnet sln add AdminPanel.Service
dotnet sln add AdminPanel.Api

dotnet add AdminPanel.Service/AdminPanel.Service.csproj reference AdminPanel.ModelsAndRepository/AdminPanel.ModelsAndRepository.csproj
dotnet add AdminPanel.Api/AdminPanel.Api.csproj reference AdminPanel.ModelsAndRepository/AdminPanel.ModelsAndRepository.csproj
dotnet add AdminPanel.Api/AdminPanel.Api.csproj reference AdminPanel.Service/AdminPanel.Service.csproj

dotnet add AdminPanel.Api package FluentValidation.AspNetCore
dotnet add AdminPanel.Api package FluentValidation.DependencyInjectionExtensions
dotnet add AdminPanel.Api package DotNetEnv
dotnet add AdminPanel.Api package AutoMapper --version 12.0.0
dotnet add AdminPanel.Api package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.0
dotnet add AdminPanel.ModelsAndRepository package MySqlConnector
dotnet add AdminPanel.ModelsAndRepository packagecode Dapper

* create some classes*

dotnet run

dotnet dev-certs https --check
dotnet dev-certs https --trust
