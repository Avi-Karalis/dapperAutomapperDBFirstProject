using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CourseLikesController : ControllerBase {
        private readonly ICourseLikesService _service;
        private readonly IMapper _mapper;

        public CourseLikesController(ICourseLikesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCourseLikes([FromBody] CourseLikesCreateDto courseLikesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CourseLikes>(courseLikesCreateDto));
                var displayDto = _mapper.Map<CourseLikesDisplayDto>(entity);
                return Created(nameof(CreateCourseLikes), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CourseLikesGetDto courseLikesGetDto) {
            try {
                var entity = await _service.GetAsync(courseLikesGetDto.Id);
                if (entity == null) {
                    return NotFound("CourseLikes with Id " + courseLikesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CourseLikesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCourseLikesAsync([FromBody] CourseLikesUpdateDto courseLikesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(courseLikesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CourseLikes with Id " + courseLikesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CourseLikes>(courseLikesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCourseLikesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CourseLikes with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CourseLikesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}