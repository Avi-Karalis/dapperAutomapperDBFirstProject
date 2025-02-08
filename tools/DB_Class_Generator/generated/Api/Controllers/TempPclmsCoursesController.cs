using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class TempPclmsCoursesController : ControllerBase {
        private readonly ITempPclmsCoursesService _service;
        private readonly IMapper _mapper;

        public TempPclmsCoursesController(ITempPclmsCoursesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateTempPclmsCourses([FromBody] TempPclmsCoursesCreateDto tempPclmsCoursesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<TempPclmsCourses>(tempPclmsCoursesCreateDto));
                var displayDto = _mapper.Map<TempPclmsCoursesDisplayDto>(entity);
                return Created(nameof(CreateTempPclmsCourses), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] TempPclmsCoursesGetDto tempPclmsCoursesGetDto) {
            try {
                var entity = await _service.GetAsync(tempPclmsCoursesGetDto.Id);
                if (entity == null) {
                    return NotFound("TempPclmsCourses with Id " + tempPclmsCoursesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<TempPclmsCoursesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateTempPclmsCoursesAsync([FromBody] TempPclmsCoursesUpdateDto tempPclmsCoursesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(tempPclmsCoursesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("TempPclmsCourses with Id " + tempPclmsCoursesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<TempPclmsCourses>(tempPclmsCoursesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteTempPclmsCoursesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("TempPclmsCourses with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<TempPclmsCoursesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}