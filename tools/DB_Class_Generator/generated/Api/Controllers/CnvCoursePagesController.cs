using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCoursePagesController : ControllerBase {
        private readonly ICnvCoursePagesService _service;
        private readonly IMapper _mapper;

        public CnvCoursePagesController(ICnvCoursePagesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCoursePages([FromBody] CnvCoursePagesCreateDto cnvCoursePagesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCoursePages>(cnvCoursePagesCreateDto));
                var displayDto = _mapper.Map<CnvCoursePagesDisplayDto>(entity);
                return Created(nameof(CreateCnvCoursePages), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCoursePagesGetDto cnvCoursePagesGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCoursePagesGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCoursePages with Id " + cnvCoursePagesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCoursePagesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCoursePagesAsync([FromBody] CnvCoursePagesUpdateDto cnvCoursePagesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCoursePagesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCoursePages with Id " + cnvCoursePagesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCoursePages>(cnvCoursePagesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCoursePagesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCoursePages with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCoursePagesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}