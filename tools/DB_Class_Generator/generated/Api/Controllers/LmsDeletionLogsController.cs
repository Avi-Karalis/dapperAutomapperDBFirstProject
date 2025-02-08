using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsDeletionLogsController : ControllerBase {
        private readonly ILmsDeletionLogsService _service;
        private readonly IMapper _mapper;

        public LmsDeletionLogsController(ILmsDeletionLogsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsDeletionLogs([FromBody] LmsDeletionLogsCreateDto lmsDeletionLogsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsDeletionLogs>(lmsDeletionLogsCreateDto));
                var displayDto = _mapper.Map<LmsDeletionLogsDisplayDto>(entity);
                return Created(nameof(CreateLmsDeletionLogs), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsDeletionLogsGetDto lmsDeletionLogsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsDeletionLogsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsDeletionLogs with Id " + lmsDeletionLogsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsDeletionLogsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsDeletionLogsAsync([FromBody] LmsDeletionLogsUpdateDto lmsDeletionLogsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsDeletionLogsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsDeletionLogs with Id " + lmsDeletionLogsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsDeletionLogs>(lmsDeletionLogsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsDeletionLogsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsDeletionLogs with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsDeletionLogsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}