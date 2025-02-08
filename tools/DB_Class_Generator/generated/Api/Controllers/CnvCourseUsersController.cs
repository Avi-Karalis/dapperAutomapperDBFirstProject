using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseUsersController : ControllerBase {
        private readonly ICnvCourseUsersService _service;
        private readonly IMapper _mapper;

        public CnvCourseUsersController(ICnvCourseUsersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseUsers([FromBody] CnvCourseUsersCreateDto cnvCourseUsersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseUsers>(cnvCourseUsersCreateDto));
                var displayDto = _mapper.Map<CnvCourseUsersDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseUsers), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseUsersGetDto cnvCourseUsersGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseUsersGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseUsers with Id " + cnvCourseUsersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseUsersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseUsersAsync([FromBody] CnvCourseUsersUpdateDto cnvCourseUsersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseUsersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseUsers with Id " + cnvCourseUsersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseUsers>(cnvCourseUsersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseUsersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseUsers with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseUsersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}