using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsCourseUsersController : ControllerBase {
        private readonly IPclmsCourseUsersService _service;
        private readonly IMapper _mapper;

        public PclmsCourseUsersController(IPclmsCourseUsersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsCourseUsers([FromBody] PclmsCourseUsersCreateDto pclmsCourseUsersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsCourseUsers>(pclmsCourseUsersCreateDto));
                var displayDto = _mapper.Map<PclmsCourseUsersDisplayDto>(entity);
                return Created(nameof(CreatePclmsCourseUsers), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsCourseUsersGetDto pclmsCourseUsersGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsCourseUsersGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsCourseUsers with Id " + pclmsCourseUsersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsCourseUsersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsCourseUsersAsync([FromBody] PclmsCourseUsersUpdateDto pclmsCourseUsersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsCourseUsersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseUsers with Id " + pclmsCourseUsersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsCourseUsers>(pclmsCourseUsersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsCourseUsersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseUsers with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsCourseUsersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}