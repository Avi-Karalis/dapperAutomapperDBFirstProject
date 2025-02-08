using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class SectionContentTranslationsController : ControllerBase {
        private readonly ISectionContentTranslationsService _service;
        private readonly IMapper _mapper;

        public SectionContentTranslationsController(ISectionContentTranslationsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateSectionContentTranslations([FromBody] SectionContentTranslationsCreateDto sectionContentTranslationsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<SectionContentTranslations>(sectionContentTranslationsCreateDto));
                var displayDto = _mapper.Map<SectionContentTranslationsDisplayDto>(entity);
                return Created(nameof(CreateSectionContentTranslations), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] SectionContentTranslationsGetDto sectionContentTranslationsGetDto) {
            try {
                var entity = await _service.GetAsync(sectionContentTranslationsGetDto.Id);
                if (entity == null) {
                    return NotFound("SectionContentTranslations with Id " + sectionContentTranslationsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<SectionContentTranslationsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateSectionContentTranslationsAsync([FromBody] SectionContentTranslationsUpdateDto sectionContentTranslationsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(sectionContentTranslationsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("SectionContentTranslations with Id " + sectionContentTranslationsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<SectionContentTranslations>(sectionContentTranslationsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteSectionContentTranslationsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("SectionContentTranslations with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<SectionContentTranslationsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}