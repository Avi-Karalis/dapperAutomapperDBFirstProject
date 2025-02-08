using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCourseSessionsTranslationsController : ControllerBase {
        private readonly ILmsCourseSessionsTranslationsService _service;
        private readonly IMapper _mapper;

        public LmsCourseSessionsTranslationsController(ILmsCourseSessionsTranslationsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCourseSessionsTranslations([FromBody] LmsCourseSessionsTranslationsCreateDto lmsCourseSessionsTranslationsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCourseSessionsTranslations>(lmsCourseSessionsTranslationsCreateDto));
                var displayDto = _mapper.Map<LmsCourseSessionsTranslationsDisplayDto>(entity);
                return Created(nameof(CreateLmsCourseSessionsTranslations), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCourseSessionsTranslationsGetDto lmsCourseSessionsTranslationsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCourseSessionsTranslationsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCourseSessionsTranslations with Id " + lmsCourseSessionsTranslationsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCourseSessionsTranslationsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCourseSessionsTranslationsAsync([FromBody] LmsCourseSessionsTranslationsUpdateDto lmsCourseSessionsTranslationsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCourseSessionsTranslationsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseSessionsTranslations with Id " + lmsCourseSessionsTranslationsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCourseSessionsTranslations>(lmsCourseSessionsTranslationsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCourseSessionsTranslationsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseSessionsTranslations with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCourseSessionsTranslationsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}