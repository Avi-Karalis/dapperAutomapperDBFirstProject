using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsChatController : ControllerBase {
        private readonly ILmsChatService _service;
        private readonly IMapper _mapper;

        public LmsChatController(ILmsChatService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsChat([FromBody] LmsChatCreateDto lmsChatCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsChat>(lmsChatCreateDto));
                var displayDto = _mapper.Map<LmsChatDisplayDto>(entity);
                return Created(nameof(CreateLmsChat), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsChatGetDto lmsChatGetDto) {
            try {
                var entity = await _service.GetAsync(lmsChatGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsChat with Id " + lmsChatGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsChatDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsChatAsync([FromBody] LmsChatUpdateDto lmsChatUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsChatUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsChat with Id " + lmsChatUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsChat>(lmsChatUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsChatAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsChat with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsChatDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}