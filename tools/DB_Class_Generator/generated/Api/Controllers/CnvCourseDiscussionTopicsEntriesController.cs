using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseDiscussionTopicsEntriesController : ControllerBase {
        private readonly ICnvCourseDiscussionTopicsEntriesService _service;
        private readonly IMapper _mapper;

        public CnvCourseDiscussionTopicsEntriesController(ICnvCourseDiscussionTopicsEntriesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseDiscussionTopicsEntries([FromBody] CnvCourseDiscussionTopicsEntriesCreateDto cnvCourseDiscussionTopicsEntriesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseDiscussionTopicsEntries>(cnvCourseDiscussionTopicsEntriesCreateDto));
                var displayDto = _mapper.Map<CnvCourseDiscussionTopicsEntriesDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseDiscussionTopicsEntries), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseDiscussionTopicsEntriesGetDto cnvCourseDiscussionTopicsEntriesGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseDiscussionTopicsEntriesGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseDiscussionTopicsEntries with Id " + cnvCourseDiscussionTopicsEntriesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseDiscussionTopicsEntriesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseDiscussionTopicsEntriesAsync([FromBody] CnvCourseDiscussionTopicsEntriesUpdateDto cnvCourseDiscussionTopicsEntriesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseDiscussionTopicsEntriesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseDiscussionTopicsEntries with Id " + cnvCourseDiscussionTopicsEntriesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseDiscussionTopicsEntries>(cnvCourseDiscussionTopicsEntriesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseDiscussionTopicsEntriesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseDiscussionTopicsEntries with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseDiscussionTopicsEntriesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}