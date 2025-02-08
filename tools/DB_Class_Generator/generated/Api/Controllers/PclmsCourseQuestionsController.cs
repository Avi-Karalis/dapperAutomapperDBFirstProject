using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsCourseQuestionsController : ControllerBase {
        private readonly IPclmsCourseQuestionsService _service;
        private readonly IMapper _mapper;

        public PclmsCourseQuestionsController(IPclmsCourseQuestionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsCourseQuestions([FromBody] PclmsCourseQuestionsCreateDto pclmsCourseQuestionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsCourseQuestions>(pclmsCourseQuestionsCreateDto));
                var displayDto = _mapper.Map<PclmsCourseQuestionsDisplayDto>(entity);
                return Created(nameof(CreatePclmsCourseQuestions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsCourseQuestionsGetDto pclmsCourseQuestionsGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsCourseQuestionsGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsCourseQuestions with Id " + pclmsCourseQuestionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsCourseQuestionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsCourseQuestionsAsync([FromBody] PclmsCourseQuestionsUpdateDto pclmsCourseQuestionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsCourseQuestionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseQuestions with Id " + pclmsCourseQuestionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsCourseQuestions>(pclmsCourseQuestionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsCourseQuestionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseQuestions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsCourseQuestionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}