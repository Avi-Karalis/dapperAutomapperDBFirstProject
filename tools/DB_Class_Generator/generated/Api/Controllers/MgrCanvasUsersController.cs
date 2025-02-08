using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasUsersController : ControllerBase {
        private readonly IMgrCanvasUsersService _service;
        private readonly IMapper _mapper;

        public MgrCanvasUsersController(IMgrCanvasUsersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasUsers([FromBody] MgrCanvasUsersCreateDto mgrCanvasUsersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasUsers>(mgrCanvasUsersCreateDto));
                var displayDto = _mapper.Map<MgrCanvasUsersDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasUsers), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasUsersGetDto mgrCanvasUsersGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasUsersGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasUsers with Id " + mgrCanvasUsersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasUsersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasUsersAsync([FromBody] MgrCanvasUsersUpdateDto mgrCanvasUsersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasUsersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasUsers with Id " + mgrCanvasUsersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasUsers>(mgrCanvasUsersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasUsersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasUsers with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasUsersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}