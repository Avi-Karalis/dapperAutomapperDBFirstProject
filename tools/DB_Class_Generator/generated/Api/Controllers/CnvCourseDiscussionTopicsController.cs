using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseDiscussionTopicsController : ControllerBase {
        private readonly ICnvCourseDiscussionTopicsService _service;
        private readonly IMapper _mapper;

        public CnvCourseDiscussionTopicsController(ICnvCourseDiscussionTopicsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseDiscussionTopics([FromBody] CnvCourseDiscussionTopicsCreateDto cnvCourseDiscussionTopicsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseDiscussionTopics>(cnvCourseDiscussionTopicsCreateDto));
                var displayDto = _mapper.Map<CnvCourseDiscussionTopicsDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseDiscussionTopics), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseDiscussionTopicsGetDto cnvCourseDiscussionTopicsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseDiscussionTopicsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseDiscussionTopics with Id " + cnvCourseDiscussionTopicsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseDiscussionTopicsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseDiscussionTopicsAsync([FromBody] CnvCourseDiscussionTopicsUpdateDto cnvCourseDiscussionTopicsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseDiscussionTopicsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseDiscussionTopics with Id " + cnvCourseDiscussionTopicsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseDiscussionTopics>(cnvCourseDiscussionTopicsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseDiscussionTopicsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseDiscussionTopics with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseDiscussionTopicsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}