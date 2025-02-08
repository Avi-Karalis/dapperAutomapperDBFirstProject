using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class ModelHasPermissionsController : ControllerBase {
        private readonly IModelHasPermissionsService _service;
        private readonly IMapper _mapper;

        public ModelHasPermissionsController(IModelHasPermissionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateModelHasPermissions([FromBody] ModelHasPermissionsCreateDto modelHasPermissionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<ModelHasPermissions>(modelHasPermissionsCreateDto));
                var displayDto = _mapper.Map<ModelHasPermissionsDisplayDto>(entity);
                return Created(nameof(CreateModelHasPermissions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] ModelHasPermissionsGetDto modelHasPermissionsGetDto) {
            try {
                var entity = await _service.GetAsync(modelHasPermissionsGetDto.Id);
                if (entity == null) {
                    return NotFound("ModelHasPermissions with Id " + modelHasPermissionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<ModelHasPermissionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateModelHasPermissionsAsync([FromBody] ModelHasPermissionsUpdateDto modelHasPermissionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(modelHasPermissionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("ModelHasPermissions with Id " + modelHasPermissionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<ModelHasPermissions>(modelHasPermissionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteModelHasPermissionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("ModelHasPermissions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<ModelHasPermissionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}