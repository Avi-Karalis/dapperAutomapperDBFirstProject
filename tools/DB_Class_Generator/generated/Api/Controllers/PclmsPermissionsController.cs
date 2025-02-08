using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsPermissionsController : ControllerBase {
        private readonly IPclmsPermissionsService _service;
        private readonly IMapper _mapper;

        public PclmsPermissionsController(IPclmsPermissionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsPermissions([FromBody] PclmsPermissionsCreateDto pclmsPermissionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsPermissions>(pclmsPermissionsCreateDto));
                var displayDto = _mapper.Map<PclmsPermissionsDisplayDto>(entity);
                return Created(nameof(CreatePclmsPermissions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsPermissionsGetDto pclmsPermissionsGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsPermissionsGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsPermissions with Id " + pclmsPermissionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsPermissionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsPermissionsAsync([FromBody] PclmsPermissionsUpdateDto pclmsPermissionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsPermissionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsPermissions with Id " + pclmsPermissionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsPermissions>(pclmsPermissionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsPermissionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsPermissions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsPermissionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}