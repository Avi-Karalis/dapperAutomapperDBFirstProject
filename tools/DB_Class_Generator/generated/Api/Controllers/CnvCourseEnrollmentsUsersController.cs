using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseEnrollmentsUsersController : ControllerBase {
        private readonly ICnvCourseEnrollmentsUsersService _service;
        private readonly IMapper _mapper;

        public CnvCourseEnrollmentsUsersController(ICnvCourseEnrollmentsUsersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseEnrollmentsUsers([FromBody] CnvCourseEnrollmentsUsersCreateDto cnvCourseEnrollmentsUsersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseEnrollmentsUsers>(cnvCourseEnrollmentsUsersCreateDto));
                var displayDto = _mapper.Map<CnvCourseEnrollmentsUsersDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseEnrollmentsUsers), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseEnrollmentsUsersGetDto cnvCourseEnrollmentsUsersGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseEnrollmentsUsersGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseEnrollmentsUsers with Id " + cnvCourseEnrollmentsUsersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseEnrollmentsUsersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseEnrollmentsUsersAsync([FromBody] CnvCourseEnrollmentsUsersUpdateDto cnvCourseEnrollmentsUsersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseEnrollmentsUsersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseEnrollmentsUsers with Id " + cnvCourseEnrollmentsUsersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseEnrollmentsUsers>(cnvCourseEnrollmentsUsersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseEnrollmentsUsersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseEnrollmentsUsers with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseEnrollmentsUsersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}