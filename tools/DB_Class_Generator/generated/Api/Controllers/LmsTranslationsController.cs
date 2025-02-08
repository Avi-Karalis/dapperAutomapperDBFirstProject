using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsTranslationsController : ControllerBase {
        private readonly ILmsTranslationsService _service;
        private readonly IMapper _mapper;

        public LmsTranslationsController(ILmsTranslationsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsTranslations([FromBody] LmsTranslationsCreateDto lmsTranslationsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsTranslations>(lmsTranslationsCreateDto));
                var displayDto = _mapper.Map<LmsTranslationsDisplayDto>(entity);
                return Created(nameof(CreateLmsTranslations), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsTranslationsGetDto lmsTranslationsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsTranslationsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsTranslations with Id " + lmsTranslationsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsTranslationsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsTranslationsAsync([FromBody] LmsTranslationsUpdateDto lmsTranslationsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsTranslationsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsTranslations with Id " + lmsTranslationsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsTranslations>(lmsTranslationsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsTranslationsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsTranslations with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsTranslationsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}