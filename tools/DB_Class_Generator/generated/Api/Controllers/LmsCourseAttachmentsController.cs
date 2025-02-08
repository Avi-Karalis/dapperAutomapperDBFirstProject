using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCourseAttachmentsController : ControllerBase {
        private readonly ILmsCourseAttachmentsService _service;
        private readonly IMapper _mapper;

        public LmsCourseAttachmentsController(ILmsCourseAttachmentsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCourseAttachments([FromBody] LmsCourseAttachmentsCreateDto lmsCourseAttachmentsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCourseAttachments>(lmsCourseAttachmentsCreateDto));
                var displayDto = _mapper.Map<LmsCourseAttachmentsDisplayDto>(entity);
                return Created(nameof(CreateLmsCourseAttachments), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCourseAttachmentsGetDto lmsCourseAttachmentsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCourseAttachmentsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCourseAttachments with Id " + lmsCourseAttachmentsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCourseAttachmentsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCourseAttachmentsAsync([FromBody] LmsCourseAttachmentsUpdateDto lmsCourseAttachmentsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCourseAttachmentsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseAttachments with Id " + lmsCourseAttachmentsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCourseAttachments>(lmsCourseAttachmentsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCourseAttachmentsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseAttachments with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCourseAttachmentsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}