using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class SectionTranslationsController : ControllerBase {
        private readonly ISectionTranslationsService _service;
        private readonly IMapper _mapper;

        public SectionTranslationsController(ISectionTranslationsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateSectionTranslations([FromBody] SectionTranslationsCreateDto sectionTranslationsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<SectionTranslations>(sectionTranslationsCreateDto));
                var displayDto = _mapper.Map<SectionTranslationsDisplayDto>(entity);
                return Created(nameof(CreateSectionTranslations), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] SectionTranslationsGetDto sectionTranslationsGetDto) {
            try {
                var entity = await _service.GetAsync(sectionTranslationsGetDto.Id);
                if (entity == null) {
                    return NotFound("SectionTranslations with Id " + sectionTranslationsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<SectionTranslationsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateSectionTranslationsAsync([FromBody] SectionTranslationsUpdateDto sectionTranslationsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(sectionTranslationsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("SectionTranslations with Id " + sectionTranslationsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<SectionTranslations>(sectionTranslationsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteSectionTranslationsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("SectionTranslations with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<SectionTranslationsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}