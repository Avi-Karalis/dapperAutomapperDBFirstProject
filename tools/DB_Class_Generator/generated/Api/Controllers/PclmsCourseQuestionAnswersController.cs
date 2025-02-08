using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsCourseQuestionAnswersController : ControllerBase {
        private readonly IPclmsCourseQuestionAnswersService _service;
        private readonly IMapper _mapper;

        public PclmsCourseQuestionAnswersController(IPclmsCourseQuestionAnswersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsCourseQuestionAnswers([FromBody] PclmsCourseQuestionAnswersCreateDto pclmsCourseQuestionAnswersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsCourseQuestionAnswers>(pclmsCourseQuestionAnswersCreateDto));
                var displayDto = _mapper.Map<PclmsCourseQuestionAnswersDisplayDto>(entity);
                return Created(nameof(CreatePclmsCourseQuestionAnswers), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsCourseQuestionAnswersGetDto pclmsCourseQuestionAnswersGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsCourseQuestionAnswersGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsCourseQuestionAnswers with Id " + pclmsCourseQuestionAnswersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsCourseQuestionAnswersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsCourseQuestionAnswersAsync([FromBody] PclmsCourseQuestionAnswersUpdateDto pclmsCourseQuestionAnswersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsCourseQuestionAnswersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseQuestionAnswers with Id " + pclmsCourseQuestionAnswersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsCourseQuestionAnswers>(pclmsCourseQuestionAnswersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsCourseQuestionAnswersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseQuestionAnswers with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsCourseQuestionAnswersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}