using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasCoursesController : ControllerBase {
        private readonly IMgrCanvasCoursesService _service;
        private readonly IMapper _mapper;

        public MgrCanvasCoursesController(IMgrCanvasCoursesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasCourses([FromBody] MgrCanvasCoursesCreateDto mgrCanvasCoursesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasCourses>(mgrCanvasCoursesCreateDto));
                var displayDto = _mapper.Map<MgrCanvasCoursesDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasCourses), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasCoursesGetDto mgrCanvasCoursesGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasCoursesGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasCourses with Id " + mgrCanvasCoursesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasCoursesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasCoursesAsync([FromBody] MgrCanvasCoursesUpdateDto mgrCanvasCoursesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasCoursesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasCourses with Id " + mgrCanvasCoursesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasCourses>(mgrCanvasCoursesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasCoursesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasCourses with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasCoursesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}