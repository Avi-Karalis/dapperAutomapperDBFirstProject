using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCourseDiscussionsController : ControllerBase {
        private readonly ILmsCourseDiscussionsService _service;
        private readonly IMapper _mapper;

        public LmsCourseDiscussionsController(ILmsCourseDiscussionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCourseDiscussions([FromBody] LmsCourseDiscussionsCreateDto lmsCourseDiscussionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCourseDiscussions>(lmsCourseDiscussionsCreateDto));
                var displayDto = _mapper.Map<LmsCourseDiscussionsDisplayDto>(entity);
                return Created(nameof(CreateLmsCourseDiscussions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCourseDiscussionsGetDto lmsCourseDiscussionsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCourseDiscussionsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCourseDiscussions with Id " + lmsCourseDiscussionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCourseDiscussionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCourseDiscussionsAsync([FromBody] LmsCourseDiscussionsUpdateDto lmsCourseDiscussionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCourseDiscussionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseDiscussions with Id " + lmsCourseDiscussionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCourseDiscussions>(lmsCourseDiscussionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCourseDiscussionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseDiscussions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCourseDiscussionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}