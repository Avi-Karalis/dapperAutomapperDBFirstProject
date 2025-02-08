using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CoursesController : ControllerBase {
        private readonly ICoursesService _service;
        private readonly IMapper _mapper;

        public CoursesController(ICoursesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCourses([FromBody] CoursesCreateDto coursesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<Courses>(coursesCreateDto));
                var displayDto = _mapper.Map<CoursesDisplayDto>(entity);
                return Created(nameof(CreateCourses), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CoursesGetDto coursesGetDto) {
            try {
                var entity = await _service.GetAsync(coursesGetDto.Id);
                if (entity == null) {
                    return NotFound("Courses with Id " + coursesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CoursesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCoursesAsync([FromBody] CoursesUpdateDto coursesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(coursesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("Courses with Id " + coursesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<Courses>(coursesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCoursesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("Courses with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CoursesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}