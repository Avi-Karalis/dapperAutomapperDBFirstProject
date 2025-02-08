using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class EventTestsController : ControllerBase {
        private readonly IEventTestsService _service;
        private readonly IMapper _mapper;

        public EventTestsController(IEventTestsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateEventTests([FromBody] EventTestsCreateDto eventTestsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<EventTests>(eventTestsCreateDto));
                var displayDto = _mapper.Map<EventTestsDisplayDto>(entity);
                return Created(nameof(CreateEventTests), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] EventTestsGetDto eventTestsGetDto) {
            try {
                var entity = await _service.GetAsync(eventTestsGetDto.Id);
                if (entity == null) {
                    return NotFound("EventTests with Id " + eventTestsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<EventTestsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateEventTestsAsync([FromBody] EventTestsUpdateDto eventTestsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(eventTestsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("EventTests with Id " + eventTestsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<EventTests>(eventTestsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteEventTestsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("EventTests with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<EventTestsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}