using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasCourseQuizzesController : ControllerBase {
        private readonly IMgrCanvasCourseQuizzesService _service;
        private readonly IMapper _mapper;

        public MgrCanvasCourseQuizzesController(IMgrCanvasCourseQuizzesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasCourseQuizzes([FromBody] MgrCanvasCourseQuizzesCreateDto mgrCanvasCourseQuizzesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasCourseQuizzes>(mgrCanvasCourseQuizzesCreateDto));
                var displayDto = _mapper.Map<MgrCanvasCourseQuizzesDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasCourseQuizzes), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasCourseQuizzesGetDto mgrCanvasCourseQuizzesGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasCourseQuizzesGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasCourseQuizzes with Id " + mgrCanvasCourseQuizzesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasCourseQuizzesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasCourseQuizzesAsync([FromBody] MgrCanvasCourseQuizzesUpdateDto mgrCanvasCourseQuizzesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasCourseQuizzesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasCourseQuizzes with Id " + mgrCanvasCourseQuizzesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasCourseQuizzes>(mgrCanvasCourseQuizzesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasCourseQuizzesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasCourseQuizzes with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasCourseQuizzesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}