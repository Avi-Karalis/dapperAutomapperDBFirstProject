using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseRecentStudentsController : ControllerBase {
        private readonly ICnvCourseRecentStudentsService _service;
        private readonly IMapper _mapper;

        public CnvCourseRecentStudentsController(ICnvCourseRecentStudentsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseRecentStudents([FromBody] CnvCourseRecentStudentsCreateDto cnvCourseRecentStudentsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseRecentStudents>(cnvCourseRecentStudentsCreateDto));
                var displayDto = _mapper.Map<CnvCourseRecentStudentsDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseRecentStudents), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseRecentStudentsGetDto cnvCourseRecentStudentsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseRecentStudentsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseRecentStudents with Id " + cnvCourseRecentStudentsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseRecentStudentsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseRecentStudentsAsync([FromBody] CnvCourseRecentStudentsUpdateDto cnvCourseRecentStudentsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseRecentStudentsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseRecentStudents with Id " + cnvCourseRecentStudentsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseRecentStudents>(cnvCourseRecentStudentsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseRecentStudentsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseRecentStudents with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseRecentStudentsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}