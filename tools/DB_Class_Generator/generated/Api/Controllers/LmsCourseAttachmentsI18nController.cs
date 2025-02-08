using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCourseAttachmentsI18nController : ControllerBase {
        private readonly ILmsCourseAttachmentsI18nService _service;
        private readonly IMapper _mapper;

        public LmsCourseAttachmentsI18nController(ILmsCourseAttachmentsI18nService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCourseAttachmentsI18n([FromBody] LmsCourseAttachmentsI18nCreateDto lmsCourseAttachmentsI18nCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCourseAttachmentsI18n>(lmsCourseAttachmentsI18nCreateDto));
                var displayDto = _mapper.Map<LmsCourseAttachmentsI18nDisplayDto>(entity);
                return Created(nameof(CreateLmsCourseAttachmentsI18n), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCourseAttachmentsI18nGetDto lmsCourseAttachmentsI18nGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCourseAttachmentsI18nGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCourseAttachmentsI18n with Id " + lmsCourseAttachmentsI18nGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCourseAttachmentsI18nDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCourseAttachmentsI18nAsync([FromBody] LmsCourseAttachmentsI18nUpdateDto lmsCourseAttachmentsI18nUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCourseAttachmentsI18nUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseAttachmentsI18n with Id " + lmsCourseAttachmentsI18nUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCourseAttachmentsI18n>(lmsCourseAttachmentsI18nUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCourseAttachmentsI18nAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseAttachmentsI18n with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCourseAttachmentsI18nDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}