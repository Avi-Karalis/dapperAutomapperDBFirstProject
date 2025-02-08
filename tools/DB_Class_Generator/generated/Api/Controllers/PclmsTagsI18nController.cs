using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsTagsI18nController : ControllerBase {
        private readonly IPclmsTagsI18nService _service;
        private readonly IMapper _mapper;

        public PclmsTagsI18nController(IPclmsTagsI18nService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsTagsI18n([FromBody] PclmsTagsI18nCreateDto pclmsTagsI18nCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsTagsI18n>(pclmsTagsI18nCreateDto));
                var displayDto = _mapper.Map<PclmsTagsI18nDisplayDto>(entity);
                return Created(nameof(CreatePclmsTagsI18n), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsTagsI18nGetDto pclmsTagsI18nGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsTagsI18nGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsTagsI18n with Id " + pclmsTagsI18nGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsTagsI18nDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsTagsI18nAsync([FromBody] PclmsTagsI18nUpdateDto pclmsTagsI18nUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsTagsI18nUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsTagsI18n with Id " + pclmsTagsI18nUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsTagsI18n>(pclmsTagsI18nUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsTagsI18nAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsTagsI18n with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsTagsI18nDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}