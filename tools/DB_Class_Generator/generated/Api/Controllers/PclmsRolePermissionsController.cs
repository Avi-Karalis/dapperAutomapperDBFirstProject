using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsRolePermissionsController : ControllerBase {
        private readonly IPclmsRolePermissionsService _service;
        private readonly IMapper _mapper;

        public PclmsRolePermissionsController(IPclmsRolePermissionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsRolePermissions([FromBody] PclmsRolePermissionsCreateDto pclmsRolePermissionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsRolePermissions>(pclmsRolePermissionsCreateDto));
                var displayDto = _mapper.Map<PclmsRolePermissionsDisplayDto>(entity);
                return Created(nameof(CreatePclmsRolePermissions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsRolePermissionsGetDto pclmsRolePermissionsGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsRolePermissionsGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsRolePermissions with Id " + pclmsRolePermissionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsRolePermissionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsRolePermissionsAsync([FromBody] PclmsRolePermissionsUpdateDto pclmsRolePermissionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsRolePermissionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsRolePermissions with Id " + pclmsRolePermissionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsRolePermissions>(pclmsRolePermissionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsRolePermissionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsRolePermissions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsRolePermissionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}