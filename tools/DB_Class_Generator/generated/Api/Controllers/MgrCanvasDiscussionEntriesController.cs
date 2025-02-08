using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasDiscussionEntriesController : ControllerBase {
        private readonly IMgrCanvasDiscussionEntriesService _service;
        private readonly IMapper _mapper;

        public MgrCanvasDiscussionEntriesController(IMgrCanvasDiscussionEntriesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasDiscussionEntries([FromBody] MgrCanvasDiscussionEntriesCreateDto mgrCanvasDiscussionEntriesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasDiscussionEntries>(mgrCanvasDiscussionEntriesCreateDto));
                var displayDto = _mapper.Map<MgrCanvasDiscussionEntriesDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasDiscussionEntries), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasDiscussionEntriesGetDto mgrCanvasDiscussionEntriesGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasDiscussionEntriesGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasDiscussionEntries with Id " + mgrCanvasDiscussionEntriesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasDiscussionEntriesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasDiscussionEntriesAsync([FromBody] MgrCanvasDiscussionEntriesUpdateDto mgrCanvasDiscussionEntriesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasDiscussionEntriesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasDiscussionEntries with Id " + mgrCanvasDiscussionEntriesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasDiscussionEntries>(mgrCanvasDiscussionEntriesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasDiscussionEntriesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasDiscussionEntries with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasDiscussionEntriesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}