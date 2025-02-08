using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsPositionsController : ControllerBase {
        private readonly ILmsPositionsService _service;
        private readonly IMapper _mapper;

        public LmsPositionsController(ILmsPositionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsPositions([FromBody] LmsPositionsCreateDto lmsPositionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsPositions>(lmsPositionsCreateDto));
                var displayDto = _mapper.Map<LmsPositionsDisplayDto>(entity);
                return Created(nameof(CreateLmsPositions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsPositionsGetDto lmsPositionsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsPositionsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsPositions with Id " + lmsPositionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsPositionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsPositionsAsync([FromBody] LmsPositionsUpdateDto lmsPositionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsPositionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsPositions with Id " + lmsPositionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsPositions>(lmsPositionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsPositionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsPositions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsPositionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}