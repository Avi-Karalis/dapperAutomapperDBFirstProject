using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PermissionsController : ControllerBase {
        private readonly IPermissionsService _service;
        private readonly IMapper _mapper;

        public PermissionsController(IPermissionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePermissions([FromBody] PermissionsCreateDto permissionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<Permissions>(permissionsCreateDto));
                var displayDto = _mapper.Map<PermissionsDisplayDto>(entity);
                return Created(nameof(CreatePermissions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PermissionsGetDto permissionsGetDto) {
            try {
                var entity = await _service.GetAsync(permissionsGetDto.Id);
                if (entity == null) {
                    return NotFound("Permissions with Id " + permissionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PermissionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePermissionsAsync([FromBody] PermissionsUpdateDto permissionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(permissionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("Permissions with Id " + permissionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<Permissions>(permissionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePermissionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("Permissions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PermissionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}