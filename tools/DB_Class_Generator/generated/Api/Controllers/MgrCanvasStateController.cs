using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasStateController : ControllerBase {
        private readonly IMgrCanvasStateService _service;
        private readonly IMapper _mapper;

        public MgrCanvasStateController(IMgrCanvasStateService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasState([FromBody] MgrCanvasStateCreateDto mgrCanvasStateCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasState>(mgrCanvasStateCreateDto));
                var displayDto = _mapper.Map<MgrCanvasStateDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasState), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasStateGetDto mgrCanvasStateGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasStateGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasState with Id " + mgrCanvasStateGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasStateDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasStateAsync([FromBody] MgrCanvasStateUpdateDto mgrCanvasStateUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasStateUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasState with Id " + mgrCanvasStateUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasState>(mgrCanvasStateUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasStateAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasState with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasStateDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}