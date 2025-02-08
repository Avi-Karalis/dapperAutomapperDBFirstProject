using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasCoursesBckController : ControllerBase {
        private readonly IMgrCanvasCoursesBckService _service;
        private readonly IMapper _mapper;

        public MgrCanvasCoursesBckController(IMgrCanvasCoursesBckService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasCoursesBck([FromBody] MgrCanvasCoursesBckCreateDto mgrCanvasCoursesBckCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasCoursesBck>(mgrCanvasCoursesBckCreateDto));
                var displayDto = _mapper.Map<MgrCanvasCoursesBckDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasCoursesBck), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasCoursesBckGetDto mgrCanvasCoursesBckGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasCoursesBckGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasCoursesBck with Id " + mgrCanvasCoursesBckGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasCoursesBckDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasCoursesBckAsync([FromBody] MgrCanvasCoursesBckUpdateDto mgrCanvasCoursesBckUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasCoursesBckUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasCoursesBck with Id " + mgrCanvasCoursesBckUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasCoursesBck>(mgrCanvasCoursesBckUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasCoursesBckAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasCoursesBck with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasCoursesBckDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}