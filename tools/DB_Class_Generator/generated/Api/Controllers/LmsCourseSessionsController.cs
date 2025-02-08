using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCourseSessionsController : ControllerBase {
        private readonly ILmsCourseSessionsService _service;
        private readonly IMapper _mapper;

        public LmsCourseSessionsController(ILmsCourseSessionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCourseSessions([FromBody] LmsCourseSessionsCreateDto lmsCourseSessionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCourseSessions>(lmsCourseSessionsCreateDto));
                var displayDto = _mapper.Map<LmsCourseSessionsDisplayDto>(entity);
                return Created(nameof(CreateLmsCourseSessions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCourseSessionsGetDto lmsCourseSessionsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCourseSessionsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCourseSessions with Id " + lmsCourseSessionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCourseSessionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCourseSessionsAsync([FromBody] LmsCourseSessionsUpdateDto lmsCourseSessionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCourseSessionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseSessions with Id " + lmsCourseSessionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCourseSessions>(lmsCourseSessionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCourseSessionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseSessions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCourseSessionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}