using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsLovsController : ControllerBase {
        private readonly ILmsLovsService _service;
        private readonly IMapper _mapper;

        public LmsLovsController(ILmsLovsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsLovs([FromBody] LmsLovsCreateDto lmsLovsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsLovs>(lmsLovsCreateDto));
                var displayDto = _mapper.Map<LmsLovsDisplayDto>(entity);
                return Created(nameof(CreateLmsLovs), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsLovsGetDto lmsLovsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsLovsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsLovs with Id " + lmsLovsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsLovsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsLovsAsync([FromBody] LmsLovsUpdateDto lmsLovsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsLovsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsLovs with Id " + lmsLovsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsLovs>(lmsLovsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsLovsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsLovs with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsLovsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}