using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsIntegrationController : ControllerBase {
        private readonly ILmsIntegrationService _service;
        private readonly IMapper _mapper;

        public LmsIntegrationController(ILmsIntegrationService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsIntegration([FromBody] LmsIntegrationCreateDto lmsIntegrationCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsIntegration>(lmsIntegrationCreateDto));
                var displayDto = _mapper.Map<LmsIntegrationDisplayDto>(entity);
                return Created(nameof(CreateLmsIntegration), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsIntegrationGetDto lmsIntegrationGetDto) {
            try {
                var entity = await _service.GetAsync(lmsIntegrationGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsIntegration with Id " + lmsIntegrationGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsIntegrationDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsIntegrationAsync([FromBody] LmsIntegrationUpdateDto lmsIntegrationUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsIntegrationUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsIntegration with Id " + lmsIntegrationUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsIntegration>(lmsIntegrationUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsIntegrationAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsIntegration with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsIntegrationDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}