using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsUsersController : ControllerBase {
        private readonly IPclmsUsersService _service;
        private readonly IMapper _mapper;

        public PclmsUsersController(IPclmsUsersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsUsers([FromBody] PclmsUsersCreateDto pclmsUsersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsUsers>(pclmsUsersCreateDto));
                var displayDto = _mapper.Map<PclmsUsersDisplayDto>(entity);
                return Created(nameof(CreatePclmsUsers), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsUsersGetDto pclmsUsersGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsUsersGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsUsers with Id " + pclmsUsersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsUsersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsUsersAsync([FromBody] PclmsUsersUpdateDto pclmsUsersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsUsersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsUsers with Id " + pclmsUsersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsUsers>(pclmsUsersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsUsersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsUsers with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsUsersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}