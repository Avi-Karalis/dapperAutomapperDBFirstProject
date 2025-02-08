using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasCourseController : ControllerBase {
        private readonly IMgrCanvasCourseService _service;
        private readonly IMapper _mapper;

        public MgrCanvasCourseController(IMgrCanvasCourseService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasCourse([FromBody] MgrCanvasCourseCreateDto mgrCanvasCourseCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasCourse>(mgrCanvasCourseCreateDto));
                var displayDto = _mapper.Map<MgrCanvasCourseDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasCourse), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasCourseGetDto mgrCanvasCourseGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasCourseGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasCourse with Id " + mgrCanvasCourseGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasCourseDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasCourseAsync([FromBody] MgrCanvasCourseUpdateDto mgrCanvasCourseUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasCourseUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasCourse with Id " + mgrCanvasCourseUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasCourse>(mgrCanvasCourseUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasCourseAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasCourse with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasCourseDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}