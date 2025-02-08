using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class RoleHasPermissionsController : ControllerBase {
        private readonly IRoleHasPermissionsService _service;
        private readonly IMapper _mapper;

        public RoleHasPermissionsController(IRoleHasPermissionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateRoleHasPermissions([FromBody] RoleHasPermissionsCreateDto roleHasPermissionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<RoleHasPermissions>(roleHasPermissionsCreateDto));
                var displayDto = _mapper.Map<RoleHasPermissionsDisplayDto>(entity);
                return Created(nameof(CreateRoleHasPermissions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] RoleHasPermissionsGetDto roleHasPermissionsGetDto) {
            try {
                var entity = await _service.GetAsync(roleHasPermissionsGetDto.Id);
                if (entity == null) {
                    return NotFound("RoleHasPermissions with Id " + roleHasPermissionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<RoleHasPermissionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateRoleHasPermissionsAsync([FromBody] RoleHasPermissionsUpdateDto roleHasPermissionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(roleHasPermissionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("RoleHasPermissions with Id " + roleHasPermissionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<RoleHasPermissions>(roleHasPermissionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteRoleHasPermissionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("RoleHasPermissions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<RoleHasPermissionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}