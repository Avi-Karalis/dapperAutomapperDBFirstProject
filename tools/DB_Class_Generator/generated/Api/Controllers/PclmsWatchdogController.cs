using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsWatchdogController : ControllerBase {
        private readonly IPclmsWatchdogService _service;
        private readonly IMapper _mapper;

        public PclmsWatchdogController(IPclmsWatchdogService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsWatchdog([FromBody] PclmsWatchdogCreateDto pclmsWatchdogCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsWatchdog>(pclmsWatchdogCreateDto));
                var displayDto = _mapper.Map<PclmsWatchdogDisplayDto>(entity);
                return Created(nameof(CreatePclmsWatchdog), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsWatchdogGetDto pclmsWatchdogGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsWatchdogGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsWatchdog with Id " + pclmsWatchdogGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsWatchdogDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsWatchdogAsync([FromBody] PclmsWatchdogUpdateDto pclmsWatchdogUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsWatchdogUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsWatchdog with Id " + pclmsWatchdogUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsWatchdog>(pclmsWatchdogUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsWatchdogAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsWatchdog with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsWatchdogDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}