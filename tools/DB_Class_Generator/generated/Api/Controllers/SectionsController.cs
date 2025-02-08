using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class SectionsController : ControllerBase {
        private readonly ISectionsService _service;
        private readonly IMapper _mapper;

        public SectionsController(ISectionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateSections([FromBody] SectionsCreateDto sectionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<Sections>(sectionsCreateDto));
                var displayDto = _mapper.Map<SectionsDisplayDto>(entity);
                return Created(nameof(CreateSections), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] SectionsGetDto sectionsGetDto) {
            try {
                var entity = await _service.GetAsync(sectionsGetDto.Id);
                if (entity == null) {
                    return NotFound("Sections with Id " + sectionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<SectionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateSectionsAsync([FromBody] SectionsUpdateDto sectionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(sectionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("Sections with Id " + sectionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<Sections>(sectionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteSectionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("Sections with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<SectionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}