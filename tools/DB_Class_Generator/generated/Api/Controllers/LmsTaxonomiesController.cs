using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsTaxonomiesController : ControllerBase {
        private readonly ILmsTaxonomiesService _service;
        private readonly IMapper _mapper;

        public LmsTaxonomiesController(ILmsTaxonomiesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsTaxonomies([FromBody] LmsTaxonomiesCreateDto lmsTaxonomiesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsTaxonomies>(lmsTaxonomiesCreateDto));
                var displayDto = _mapper.Map<LmsTaxonomiesDisplayDto>(entity);
                return Created(nameof(CreateLmsTaxonomies), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsTaxonomiesGetDto lmsTaxonomiesGetDto) {
            try {
                var entity = await _service.GetAsync(lmsTaxonomiesGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsTaxonomies with Id " + lmsTaxonomiesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsTaxonomiesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsTaxonomiesAsync([FromBody] LmsTaxonomiesUpdateDto lmsTaxonomiesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsTaxonomiesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsTaxonomies with Id " + lmsTaxonomiesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsTaxonomies>(lmsTaxonomiesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsTaxonomiesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsTaxonomies with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsTaxonomiesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}