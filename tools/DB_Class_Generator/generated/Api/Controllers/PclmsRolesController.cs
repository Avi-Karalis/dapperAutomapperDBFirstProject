using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsRolesController : ControllerBase {
        private readonly IPclmsRolesService _service;
        private readonly IMapper _mapper;

        public PclmsRolesController(IPclmsRolesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsRoles([FromBody] PclmsRolesCreateDto pclmsRolesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsRoles>(pclmsRolesCreateDto));
                var displayDto = _mapper.Map<PclmsRolesDisplayDto>(entity);
                return Created(nameof(CreatePclmsRoles), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsRolesGetDto pclmsRolesGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsRolesGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsRoles with Id " + pclmsRolesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsRolesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsRolesAsync([FromBody] PclmsRolesUpdateDto pclmsRolesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsRolesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsRoles with Id " + pclmsRolesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsRoles>(pclmsRolesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsRolesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsRoles with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsRolesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}