using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasDiscussionTopicsController : ControllerBase {
        private readonly IMgrCanvasDiscussionTopicsService _service;
        private readonly IMapper _mapper;

        public MgrCanvasDiscussionTopicsController(IMgrCanvasDiscussionTopicsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasDiscussionTopics([FromBody] MgrCanvasDiscussionTopicsCreateDto mgrCanvasDiscussionTopicsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasDiscussionTopics>(mgrCanvasDiscussionTopicsCreateDto));
                var displayDto = _mapper.Map<MgrCanvasDiscussionTopicsDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasDiscussionTopics), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasDiscussionTopicsGetDto mgrCanvasDiscussionTopicsGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasDiscussionTopicsGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasDiscussionTopics with Id " + mgrCanvasDiscussionTopicsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasDiscussionTopicsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasDiscussionTopicsAsync([FromBody] MgrCanvasDiscussionTopicsUpdateDto mgrCanvasDiscussionTopicsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasDiscussionTopicsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasDiscussionTopics with Id " + mgrCanvasDiscussionTopicsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasDiscussionTopics>(mgrCanvasDiscussionTopicsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasDiscussionTopicsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasDiscussionTopics with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasDiscussionTopicsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}