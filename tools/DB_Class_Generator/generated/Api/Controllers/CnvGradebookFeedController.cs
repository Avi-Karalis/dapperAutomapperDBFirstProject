using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvGradebookFeedController : ControllerBase {
        private readonly ICnvGradebookFeedService _service;
        private readonly IMapper _mapper;

        public CnvGradebookFeedController(ICnvGradebookFeedService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvGradebookFeed([FromBody] CnvGradebookFeedCreateDto cnvGradebookFeedCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvGradebookFeed>(cnvGradebookFeedCreateDto));
                var displayDto = _mapper.Map<CnvGradebookFeedDisplayDto>(entity);
                return Created(nameof(CreateCnvGradebookFeed), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvGradebookFeedGetDto cnvGradebookFeedGetDto) {
            try {
                var entity = await _service.GetAsync(cnvGradebookFeedGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvGradebookFeed with Id " + cnvGradebookFeedGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvGradebookFeedDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvGradebookFeedAsync([FromBody] CnvGradebookFeedUpdateDto cnvGradebookFeedUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvGradebookFeedUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvGradebookFeed with Id " + cnvGradebookFeedUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvGradebookFeed>(cnvGradebookFeedUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvGradebookFeedAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvGradebookFeed with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvGradebookFeedDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}