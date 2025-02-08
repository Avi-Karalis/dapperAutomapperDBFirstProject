using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class NestedSetTestController : ControllerBase {
        private readonly INestedSetTestService _service;
        private readonly IMapper _mapper;

        public NestedSetTestController(INestedSetTestService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateNestedSetTest([FromBody] NestedSetTestCreateDto nestedSetTestCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<NestedSetTest>(nestedSetTestCreateDto));
                var displayDto = _mapper.Map<NestedSetTestDisplayDto>(entity);
                return Created(nameof(CreateNestedSetTest), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] NestedSetTestGetDto nestedSetTestGetDto) {
            try {
                var entity = await _service.GetAsync(nestedSetTestGetDto.Id);
                if (entity == null) {
                    return NotFound("NestedSetTest with Id " + nestedSetTestGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<NestedSetTestDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateNestedSetTestAsync([FromBody] NestedSetTestUpdateDto nestedSetTestUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(nestedSetTestUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("NestedSetTest with Id " + nestedSetTestUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<NestedSetTest>(nestedSetTestUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteNestedSetTestAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("NestedSetTest with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<NestedSetTestDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}