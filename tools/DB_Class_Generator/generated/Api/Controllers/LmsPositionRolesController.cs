using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsPositionRolesController : ControllerBase {
        private readonly ILmsPositionRolesService _service;
        private readonly IMapper _mapper;

        public LmsPositionRolesController(ILmsPositionRolesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsPositionRoles([FromBody] LmsPositionRolesCreateDto lmsPositionRolesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsPositionRoles>(lmsPositionRolesCreateDto));
                var displayDto = _mapper.Map<LmsPositionRolesDisplayDto>(entity);
                return Created(nameof(CreateLmsPositionRoles), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsPositionRolesGetDto lmsPositionRolesGetDto) {
            try {
                var entity = await _service.GetAsync(lmsPositionRolesGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsPositionRoles with Id " + lmsPositionRolesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsPositionRolesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsPositionRolesAsync([FromBody] LmsPositionRolesUpdateDto lmsPositionRolesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsPositionRolesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsPositionRoles with Id " + lmsPositionRolesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsPositionRoles>(lmsPositionRolesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsPositionRolesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsPositionRoles with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsPositionRolesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}