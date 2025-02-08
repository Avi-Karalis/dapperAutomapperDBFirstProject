using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CourseTranslationsController : ControllerBase {
        private readonly ICourseTranslationsService _service;
        private readonly IMapper _mapper;

        public CourseTranslationsController(ICourseTranslationsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCourseTranslations([FromBody] CourseTranslationsCreateDto courseTranslationsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CourseTranslations>(courseTranslationsCreateDto));
                var displayDto = _mapper.Map<CourseTranslationsDisplayDto>(entity);
                return Created(nameof(CreateCourseTranslations), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CourseTranslationsGetDto courseTranslationsGetDto) {
            try {
                var entity = await _service.GetAsync(courseTranslationsGetDto.Id);
                if (entity == null) {
                    return NotFound("CourseTranslations with Id " + courseTranslationsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CourseTranslationsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCourseTranslationsAsync([FromBody] CourseTranslationsUpdateDto courseTranslationsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(courseTranslationsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CourseTranslations with Id " + courseTranslationsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CourseTranslations>(courseTranslationsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCourseTranslationsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CourseTranslations with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CourseTranslationsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}