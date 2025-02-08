using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsTranslationLanguagesController : ControllerBase {
        private readonly ILmsTranslationLanguagesService _service;
        private readonly IMapper _mapper;

        public LmsTranslationLanguagesController(ILmsTranslationLanguagesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsTranslationLanguages([FromBody] LmsTranslationLanguagesCreateDto lmsTranslationLanguagesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsTranslationLanguages>(lmsTranslationLanguagesCreateDto));
                var displayDto = _mapper.Map<LmsTranslationLanguagesDisplayDto>(entity);
                return Created(nameof(CreateLmsTranslationLanguages), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsTranslationLanguagesGetDto lmsTranslationLanguagesGetDto) {
            try {
                var entity = await _service.GetAsync(lmsTranslationLanguagesGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsTranslationLanguages with Id " + lmsTranslationLanguagesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsTranslationLanguagesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsTranslationLanguagesAsync([FromBody] LmsTranslationLanguagesUpdateDto lmsTranslationLanguagesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsTranslationLanguagesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsTranslationLanguages with Id " + lmsTranslationLanguagesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsTranslationLanguages>(lmsTranslationLanguagesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsTranslationLanguagesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsTranslationLanguages with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsTranslationLanguagesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}