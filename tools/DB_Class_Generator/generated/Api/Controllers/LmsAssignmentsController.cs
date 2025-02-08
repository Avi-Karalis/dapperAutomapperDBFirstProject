using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsAssignmentsController : ControllerBase {
        private readonly ILmsAssignmentsService _service;
        private readonly IMapper _mapper;

        public LmsAssignmentsController(ILmsAssignmentsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsAssignments([FromBody] LmsAssignmentsCreateDto lmsAssignmentsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsAssignments>(lmsAssignmentsCreateDto));
                var displayDto = _mapper.Map<LmsAssignmentsDisplayDto>(entity);
                return Created(nameof(CreateLmsAssignments), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsAssignmentsGetDto lmsAssignmentsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsAssignmentsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsAssignments with Id " + lmsAssignmentsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsAssignmentsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsAssignmentsAsync([FromBody] LmsAssignmentsUpdateDto lmsAssignmentsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsAssignmentsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsAssignments with Id " + lmsAssignmentsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsAssignments>(lmsAssignmentsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsAssignmentsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsAssignments with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsAssignmentsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}