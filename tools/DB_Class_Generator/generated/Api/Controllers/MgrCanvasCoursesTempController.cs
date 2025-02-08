using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasCoursesTempController : ControllerBase {
        private readonly IMgrCanvasCoursesTempService _service;
        private readonly IMapper _mapper;

        public MgrCanvasCoursesTempController(IMgrCanvasCoursesTempService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasCoursesTemp([FromBody] MgrCanvasCoursesTempCreateDto mgrCanvasCoursesTempCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasCoursesTemp>(mgrCanvasCoursesTempCreateDto));
                var displayDto = _mapper.Map<MgrCanvasCoursesTempDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasCoursesTemp), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasCoursesTempGetDto mgrCanvasCoursesTempGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasCoursesTempGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasCoursesTemp with Id " + mgrCanvasCoursesTempGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasCoursesTempDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasCoursesTempAsync([FromBody] MgrCanvasCoursesTempUpdateDto mgrCanvasCoursesTempUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasCoursesTempUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasCoursesTemp with Id " + mgrCanvasCoursesTempUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasCoursesTemp>(mgrCanvasCoursesTempUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasCoursesTempAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasCoursesTemp with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasCoursesTempDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}