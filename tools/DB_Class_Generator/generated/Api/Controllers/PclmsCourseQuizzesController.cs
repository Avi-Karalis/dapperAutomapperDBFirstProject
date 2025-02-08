using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsCourseQuizzesController : ControllerBase {
        private readonly IPclmsCourseQuizzesService _service;
        private readonly IMapper _mapper;

        public PclmsCourseQuizzesController(IPclmsCourseQuizzesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsCourseQuizzes([FromBody] PclmsCourseQuizzesCreateDto pclmsCourseQuizzesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsCourseQuizzes>(pclmsCourseQuizzesCreateDto));
                var displayDto = _mapper.Map<PclmsCourseQuizzesDisplayDto>(entity);
                return Created(nameof(CreatePclmsCourseQuizzes), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsCourseQuizzesGetDto pclmsCourseQuizzesGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsCourseQuizzesGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsCourseQuizzes with Id " + pclmsCourseQuizzesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsCourseQuizzesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsCourseQuizzesAsync([FromBody] PclmsCourseQuizzesUpdateDto pclmsCourseQuizzesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsCourseQuizzesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseQuizzes with Id " + pclmsCourseQuizzesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsCourseQuizzes>(pclmsCourseQuizzesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsCourseQuizzesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseQuizzes with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsCourseQuizzesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}