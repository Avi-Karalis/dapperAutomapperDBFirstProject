using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LanguagesI18nController : ControllerBase {
        private readonly ILanguagesI18nService _service;
        private readonly IMapper _mapper;

        public LanguagesI18nController(ILanguagesI18nService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLanguagesI18n([FromBody] LanguagesI18nCreateDto languagesI18nCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LanguagesI18n>(languagesI18nCreateDto));
                var displayDto = _mapper.Map<LanguagesI18nDisplayDto>(entity);
                return Created(nameof(CreateLanguagesI18n), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LanguagesI18nGetDto languagesI18nGetDto) {
            try {
                var entity = await _service.GetAsync(languagesI18nGetDto.Id);
                if (entity == null) {
                    return NotFound("LanguagesI18n with Id " + languagesI18nGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LanguagesI18nDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLanguagesI18nAsync([FromBody] LanguagesI18nUpdateDto languagesI18nUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(languagesI18nUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LanguagesI18n with Id " + languagesI18nUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LanguagesI18n>(languagesI18nUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLanguagesI18nAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LanguagesI18n with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LanguagesI18nDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}