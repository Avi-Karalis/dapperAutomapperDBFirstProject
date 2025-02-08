using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class SectionContentsController : ControllerBase {
        private readonly ISectionContentsService _service;
        private readonly IMapper _mapper;

        public SectionContentsController(ISectionContentsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateSectionContents([FromBody] SectionContentsCreateDto sectionContentsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<SectionContents>(sectionContentsCreateDto));
                var displayDto = _mapper.Map<SectionContentsDisplayDto>(entity);
                return Created(nameof(CreateSectionContents), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] SectionContentsGetDto sectionContentsGetDto) {
            try {
                var entity = await _service.GetAsync(sectionContentsGetDto.Id);
                if (entity == null) {
                    return NotFound("SectionContents with Id " + sectionContentsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<SectionContentsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateSectionContentsAsync([FromBody] SectionContentsUpdateDto sectionContentsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(sectionContentsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("SectionContents with Id " + sectionContentsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<SectionContents>(sectionContentsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteSectionContentsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("SectionContents with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<SectionContentsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}