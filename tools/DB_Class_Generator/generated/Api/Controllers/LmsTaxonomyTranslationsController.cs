using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsTaxonomyTranslationsController : ControllerBase {
        private readonly ILmsTaxonomyTranslationsService _service;
        private readonly IMapper _mapper;

        public LmsTaxonomyTranslationsController(ILmsTaxonomyTranslationsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsTaxonomyTranslations([FromBody] LmsTaxonomyTranslationsCreateDto lmsTaxonomyTranslationsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsTaxonomyTranslations>(lmsTaxonomyTranslationsCreateDto));
                var displayDto = _mapper.Map<LmsTaxonomyTranslationsDisplayDto>(entity);
                return Created(nameof(CreateLmsTaxonomyTranslations), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsTaxonomyTranslationsGetDto lmsTaxonomyTranslationsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsTaxonomyTranslationsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsTaxonomyTranslations with Id " + lmsTaxonomyTranslationsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsTaxonomyTranslationsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsTaxonomyTranslationsAsync([FromBody] LmsTaxonomyTranslationsUpdateDto lmsTaxonomyTranslationsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsTaxonomyTranslationsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsTaxonomyTranslations with Id " + lmsTaxonomyTranslationsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsTaxonomyTranslations>(lmsTaxonomyTranslationsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsTaxonomyTranslationsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsTaxonomyTranslations with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsTaxonomyTranslationsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}