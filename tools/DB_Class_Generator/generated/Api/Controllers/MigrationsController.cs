using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MigrationsController : ControllerBase {
        private readonly IMigrationsService _service;
        private readonly IMapper _mapper;

        public MigrationsController(IMigrationsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMigrations([FromBody] MigrationsCreateDto migrationsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<Migrations>(migrationsCreateDto));
                var displayDto = _mapper.Map<MigrationsDisplayDto>(entity);
                return Created(nameof(CreateMigrations), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MigrationsGetDto migrationsGetDto) {
            try {
                var entity = await _service.GetAsync(migrationsGetDto.Id);
                if (entity == null) {
                    return NotFound("Migrations with Id " + migrationsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MigrationsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMigrationsAsync([FromBody] MigrationsUpdateDto migrationsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(migrationsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("Migrations with Id " + migrationsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<Migrations>(migrationsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMigrationsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("Migrations with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MigrationsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}