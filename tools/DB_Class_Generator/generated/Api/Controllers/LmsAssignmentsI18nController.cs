using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsAssignmentsI18nController : ControllerBase {
        private readonly ILmsAssignmentsI18nService _service;
        private readonly IMapper _mapper;

        public LmsAssignmentsI18nController(ILmsAssignmentsI18nService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsAssignmentsI18n([FromBody] LmsAssignmentsI18nCreateDto lmsAssignmentsI18nCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsAssignmentsI18n>(lmsAssignmentsI18nCreateDto));
                var displayDto = _mapper.Map<LmsAssignmentsI18nDisplayDto>(entity);
                return Created(nameof(CreateLmsAssignmentsI18n), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsAssignmentsI18nGetDto lmsAssignmentsI18nGetDto) {
            try {
                var entity = await _service.GetAsync(lmsAssignmentsI18nGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsAssignmentsI18n with Id " + lmsAssignmentsI18nGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsAssignmentsI18nDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsAssignmentsI18nAsync([FromBody] LmsAssignmentsI18nUpdateDto lmsAssignmentsI18nUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsAssignmentsI18nUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsAssignmentsI18n with Id " + lmsAssignmentsI18nUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsAssignmentsI18n>(lmsAssignmentsI18nUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsAssignmentsI18nAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsAssignmentsI18n with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsAssignmentsI18nDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}