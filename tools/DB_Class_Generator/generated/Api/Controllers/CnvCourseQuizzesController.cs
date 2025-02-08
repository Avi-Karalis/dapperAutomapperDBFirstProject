using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseQuizzesController : ControllerBase {
        private readonly ICnvCourseQuizzesService _service;
        private readonly IMapper _mapper;

        public CnvCourseQuizzesController(ICnvCourseQuizzesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseQuizzes([FromBody] CnvCourseQuizzesCreateDto cnvCourseQuizzesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseQuizzes>(cnvCourseQuizzesCreateDto));
                var displayDto = _mapper.Map<CnvCourseQuizzesDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseQuizzes), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseQuizzesGetDto cnvCourseQuizzesGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseQuizzesGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseQuizzes with Id " + cnvCourseQuizzesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseQuizzesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseQuizzesAsync([FromBody] CnvCourseQuizzesUpdateDto cnvCourseQuizzesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseQuizzesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseQuizzes with Id " + cnvCourseQuizzesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseQuizzes>(cnvCourseQuizzesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseQuizzesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseQuizzes with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseQuizzesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}