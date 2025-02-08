using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseEnrollmentsController : ControllerBase {
        private readonly ICnvCourseEnrollmentsService _service;
        private readonly IMapper _mapper;

        public CnvCourseEnrollmentsController(ICnvCourseEnrollmentsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseEnrollments([FromBody] CnvCourseEnrollmentsCreateDto cnvCourseEnrollmentsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseEnrollments>(cnvCourseEnrollmentsCreateDto));
                var displayDto = _mapper.Map<CnvCourseEnrollmentsDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseEnrollments), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseEnrollmentsGetDto cnvCourseEnrollmentsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseEnrollmentsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseEnrollments with Id " + cnvCourseEnrollmentsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseEnrollmentsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseEnrollmentsAsync([FromBody] CnvCourseEnrollmentsUpdateDto cnvCourseEnrollmentsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseEnrollmentsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseEnrollments with Id " + cnvCourseEnrollmentsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseEnrollments>(cnvCourseEnrollmentsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseEnrollmentsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseEnrollments with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseEnrollmentsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}