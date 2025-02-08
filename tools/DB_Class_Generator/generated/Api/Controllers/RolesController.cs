using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class RolesController : ControllerBase {
        private readonly IRolesService _service;
        private readonly IMapper _mapper;

        public RolesController(IRolesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateRoles([FromBody] RolesCreateDto rolesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<Roles>(rolesCreateDto));
                var displayDto = _mapper.Map<RolesDisplayDto>(entity);
                return Created(nameof(CreateRoles), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] RolesGetDto rolesGetDto) {
            try {
                var entity = await _service.GetAsync(rolesGetDto.Id);
                if (entity == null) {
                    return NotFound("Roles with Id " + rolesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<RolesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateRolesAsync([FromBody] RolesUpdateDto rolesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(rolesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("Roles with Id " + rolesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<Roles>(rolesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteRolesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("Roles with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<RolesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}