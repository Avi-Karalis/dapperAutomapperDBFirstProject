using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsCoursesController : ControllerBase {
        private readonly IPclmsCoursesService _service;
        private readonly IMapper _mapper;

        public PclmsCoursesController(IPclmsCoursesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsCourses([FromBody] PclmsCoursesCreateDto pclmsCoursesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsCourses>(pclmsCoursesCreateDto));
                var displayDto = _mapper.Map<PclmsCoursesDisplayDto>(entity);
                return Created(nameof(CreatePclmsCourses), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsCoursesGetDto pclmsCoursesGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsCoursesGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsCourses with Id " + pclmsCoursesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsCoursesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsCoursesAsync([FromBody] PclmsCoursesUpdateDto pclmsCoursesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsCoursesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourses with Id " + pclmsCoursesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsCourses>(pclmsCoursesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsCoursesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourses with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsCoursesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}