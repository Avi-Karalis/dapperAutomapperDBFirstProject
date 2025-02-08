using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasAccountUsersController : ControllerBase {
        private readonly IMgrCanvasAccountUsersService _service;
        private readonly IMapper _mapper;

        public MgrCanvasAccountUsersController(IMgrCanvasAccountUsersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasAccountUsers([FromBody] MgrCanvasAccountUsersCreateDto mgrCanvasAccountUsersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasAccountUsers>(mgrCanvasAccountUsersCreateDto));
                var displayDto = _mapper.Map<MgrCanvasAccountUsersDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasAccountUsers), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasAccountUsersGetDto mgrCanvasAccountUsersGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasAccountUsersGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasAccountUsers with Id " + mgrCanvasAccountUsersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasAccountUsersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasAccountUsersAsync([FromBody] MgrCanvasAccountUsersUpdateDto mgrCanvasAccountUsersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasAccountUsersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasAccountUsers with Id " + mgrCanvasAccountUsersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasAccountUsers>(mgrCanvasAccountUsersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasAccountUsersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasAccountUsers with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasAccountUsersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}