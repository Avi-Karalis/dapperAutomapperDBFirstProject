using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class QueueJobsController : ControllerBase {
        private readonly IQueueJobsService _service;
        private readonly IMapper _mapper;

        public QueueJobsController(IQueueJobsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateQueueJobs([FromBody] QueueJobsCreateDto queueJobsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<QueueJobs>(queueJobsCreateDto));
                var displayDto = _mapper.Map<QueueJobsDisplayDto>(entity);
                return Created(nameof(CreateQueueJobs), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] QueueJobsGetDto queueJobsGetDto) {
            try {
                var entity = await _service.GetAsync(queueJobsGetDto.Id);
                if (entity == null) {
                    return NotFound("QueueJobs with Id " + queueJobsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<QueueJobsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateQueueJobsAsync([FromBody] QueueJobsUpdateDto queueJobsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(queueJobsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("QueueJobs with Id " + queueJobsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<QueueJobs>(queueJobsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteQueueJobsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("QueueJobs with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<QueueJobsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}