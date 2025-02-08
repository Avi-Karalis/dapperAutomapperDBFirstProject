using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCoursesController : ControllerBase {
        private readonly ICnvCoursesService _service;
        private readonly IMapper _mapper;

        public CnvCoursesController(ICnvCoursesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourses([FromBody] CnvCoursesCreateDto cnvCoursesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourses>(cnvCoursesCreateDto));
                var displayDto = _mapper.Map<CnvCoursesDisplayDto>(entity);
                return Created(nameof(CreateCnvCourses), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCoursesGetDto cnvCoursesGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCoursesGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourses with Id " + cnvCoursesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCoursesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCoursesAsync([FromBody] CnvCoursesUpdateDto cnvCoursesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCoursesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourses with Id " + cnvCoursesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourses>(cnvCoursesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCoursesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourses with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCoursesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}