using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsTablesController : ControllerBase {
        private readonly ILmsTablesService _service;
        private readonly IMapper _mapper;

        public LmsTablesController(ILmsTablesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsTables([FromBody] LmsTablesCreateDto lmsTablesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsTables>(lmsTablesCreateDto));
                var displayDto = _mapper.Map<LmsTablesDisplayDto>(entity);
                return Created(nameof(CreateLmsTables), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsTablesGetDto lmsTablesGetDto) {
            try {
                var entity = await _service.GetAsync(lmsTablesGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsTables with Id " + lmsTablesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsTablesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsTablesAsync([FromBody] LmsTablesUpdateDto lmsTablesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsTablesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsTables with Id " + lmsTablesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsTables>(lmsTablesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsTablesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsTables with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsTablesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}