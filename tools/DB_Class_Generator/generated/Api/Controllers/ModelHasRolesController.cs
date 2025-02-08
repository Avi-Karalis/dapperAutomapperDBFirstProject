using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class ModelHasRolesController : ControllerBase {
        private readonly IModelHasRolesService _service;
        private readonly IMapper _mapper;

        public ModelHasRolesController(IModelHasRolesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateModelHasRoles([FromBody] ModelHasRolesCreateDto modelHasRolesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<ModelHasRoles>(modelHasRolesCreateDto));
                var displayDto = _mapper.Map<ModelHasRolesDisplayDto>(entity);
                return Created(nameof(CreateModelHasRoles), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] ModelHasRolesGetDto modelHasRolesGetDto) {
            try {
                var entity = await _service.GetAsync(modelHasRolesGetDto.Id);
                if (entity == null) {
                    return NotFound("ModelHasRoles with Id " + modelHasRolesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<ModelHasRolesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateModelHasRolesAsync([FromBody] ModelHasRolesUpdateDto modelHasRolesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(modelHasRolesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("ModelHasRoles with Id " + modelHasRolesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<ModelHasRoles>(modelHasRolesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteModelHasRolesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("ModelHasRoles with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<ModelHasRolesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}