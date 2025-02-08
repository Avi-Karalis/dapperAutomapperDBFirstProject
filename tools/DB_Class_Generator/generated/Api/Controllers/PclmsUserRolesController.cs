using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsUserRolesController : ControllerBase {
        private readonly IPclmsUserRolesService _service;
        private readonly IMapper _mapper;

        public PclmsUserRolesController(IPclmsUserRolesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsUserRoles([FromBody] PclmsUserRolesCreateDto pclmsUserRolesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsUserRoles>(pclmsUserRolesCreateDto));
                var displayDto = _mapper.Map<PclmsUserRolesDisplayDto>(entity);
                return Created(nameof(CreatePclmsUserRoles), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsUserRolesGetDto pclmsUserRolesGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsUserRolesGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsUserRoles with Id " + pclmsUserRolesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsUserRolesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsUserRolesAsync([FromBody] PclmsUserRolesUpdateDto pclmsUserRolesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsUserRolesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsUserRoles with Id " + pclmsUserRolesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsUserRoles>(pclmsUserRolesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsUserRolesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsUserRoles with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsUserRolesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}