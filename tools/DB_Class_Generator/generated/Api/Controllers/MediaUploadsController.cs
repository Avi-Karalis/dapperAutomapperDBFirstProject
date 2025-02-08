using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MediaUploadsController : ControllerBase {
        private readonly IMediaUploadsService _service;
        private readonly IMapper _mapper;

        public MediaUploadsController(IMediaUploadsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMediaUploads([FromBody] MediaUploadsCreateDto mediaUploadsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MediaUploads>(mediaUploadsCreateDto));
                var displayDto = _mapper.Map<MediaUploadsDisplayDto>(entity);
                return Created(nameof(CreateMediaUploads), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MediaUploadsGetDto mediaUploadsGetDto) {
            try {
                var entity = await _service.GetAsync(mediaUploadsGetDto.Id);
                if (entity == null) {
                    return NotFound("MediaUploads with Id " + mediaUploadsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MediaUploadsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMediaUploadsAsync([FromBody] MediaUploadsUpdateDto mediaUploadsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mediaUploadsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MediaUploads with Id " + mediaUploadsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MediaUploads>(mediaUploadsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMediaUploadsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MediaUploads with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MediaUploadsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}