using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCourseTaxonomiesController : ControllerBase {
        private readonly ILmsCourseTaxonomiesService _service;
        private readonly IMapper _mapper;

        public LmsCourseTaxonomiesController(ILmsCourseTaxonomiesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCourseTaxonomies([FromBody] LmsCourseTaxonomiesCreateDto lmsCourseTaxonomiesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCourseTaxonomies>(lmsCourseTaxonomiesCreateDto));
                var displayDto = _mapper.Map<LmsCourseTaxonomiesDisplayDto>(entity);
                return Created(nameof(CreateLmsCourseTaxonomies), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCourseTaxonomiesGetDto lmsCourseTaxonomiesGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCourseTaxonomiesGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCourseTaxonomies with Id " + lmsCourseTaxonomiesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCourseTaxonomiesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCourseTaxonomiesAsync([FromBody] LmsCourseTaxonomiesUpdateDto lmsCourseTaxonomiesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCourseTaxonomiesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseTaxonomies with Id " + lmsCourseTaxonomiesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCourseTaxonomies>(lmsCourseTaxonomiesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCourseTaxonomiesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseTaxonomies with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCourseTaxonomiesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}