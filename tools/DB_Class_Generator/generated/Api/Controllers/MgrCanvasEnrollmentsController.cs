using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasEnrollmentsController : ControllerBase {
        private readonly IMgrCanvasEnrollmentsService _service;
        private readonly IMapper _mapper;

        public MgrCanvasEnrollmentsController(IMgrCanvasEnrollmentsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasEnrollments([FromBody] MgrCanvasEnrollmentsCreateDto mgrCanvasEnrollmentsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasEnrollments>(mgrCanvasEnrollmentsCreateDto));
                var displayDto = _mapper.Map<MgrCanvasEnrollmentsDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasEnrollments), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasEnrollmentsGetDto mgrCanvasEnrollmentsGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasEnrollmentsGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasEnrollments with Id " + mgrCanvasEnrollmentsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasEnrollmentsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasEnrollmentsAsync([FromBody] MgrCanvasEnrollmentsUpdateDto mgrCanvasEnrollmentsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasEnrollmentsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasEnrollments with Id " + mgrCanvasEnrollmentsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasEnrollments>(mgrCanvasEnrollmentsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasEnrollmentsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasEnrollments with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasEnrollmentsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}