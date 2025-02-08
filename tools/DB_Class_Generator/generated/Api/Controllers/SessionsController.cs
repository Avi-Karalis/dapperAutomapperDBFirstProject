using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class SessionsController : ControllerBase {
        private readonly ISessionsService _service;
        private readonly IMapper _mapper;

        public SessionsController(ISessionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateSessions([FromBody] SessionsCreateDto sessionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<Sessions>(sessionsCreateDto));
                var displayDto = _mapper.Map<SessionsDisplayDto>(entity);
                return Created(nameof(CreateSessions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] SessionsGetDto sessionsGetDto) {
            try {
                var entity = await _service.GetAsync(sessionsGetDto.Id);
                if (entity == null) {
                    return NotFound("Sessions with Id " + sessionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<SessionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateSessionsAsync([FromBody] SessionsUpdateDto sessionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(sessionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("Sessions with Id " + sessionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<Sessions>(sessionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteSessionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("Sessions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<SessionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}