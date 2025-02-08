using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseAssignmentsController : ControllerBase {
        private readonly ICnvCourseAssignmentsService _service;
        private readonly IMapper _mapper;

        public CnvCourseAssignmentsController(ICnvCourseAssignmentsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseAssignments([FromBody] CnvCourseAssignmentsCreateDto cnvCourseAssignmentsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseAssignments>(cnvCourseAssignmentsCreateDto));
                var displayDto = _mapper.Map<CnvCourseAssignmentsDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseAssignments), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseAssignmentsGetDto cnvCourseAssignmentsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseAssignmentsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseAssignments with Id " + cnvCourseAssignmentsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseAssignmentsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseAssignmentsAsync([FromBody] CnvCourseAssignmentsUpdateDto cnvCourseAssignmentsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseAssignmentsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseAssignments with Id " + cnvCourseAssignmentsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseAssignments>(cnvCourseAssignmentsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseAssignmentsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseAssignments with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseAssignmentsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}