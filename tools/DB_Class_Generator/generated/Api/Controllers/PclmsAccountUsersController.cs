using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsAccountUsersController : ControllerBase {
        private readonly IPclmsAccountUsersService _service;
        private readonly IMapper _mapper;

        public PclmsAccountUsersController(IPclmsAccountUsersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsAccountUsers([FromBody] PclmsAccountUsersCreateDto pclmsAccountUsersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsAccountUsers>(pclmsAccountUsersCreateDto));
                var displayDto = _mapper.Map<PclmsAccountUsersDisplayDto>(entity);
                return Created(nameof(CreatePclmsAccountUsers), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsAccountUsersGetDto pclmsAccountUsersGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsAccountUsersGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsAccountUsers with Id " + pclmsAccountUsersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsAccountUsersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsAccountUsersAsync([FromBody] PclmsAccountUsersUpdateDto pclmsAccountUsersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsAccountUsersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsAccountUsers with Id " + pclmsAccountUsersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsAccountUsers>(pclmsAccountUsersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsAccountUsersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsAccountUsers with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsAccountUsersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}