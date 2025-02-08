using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsTagsController : ControllerBase {
        private readonly IPclmsTagsService _service;
        private readonly IMapper _mapper;

        public PclmsTagsController(IPclmsTagsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsTags([FromBody] PclmsTagsCreateDto pclmsTagsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsTags>(pclmsTagsCreateDto));
                var displayDto = _mapper.Map<PclmsTagsDisplayDto>(entity);
                return Created(nameof(CreatePclmsTags), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsTagsGetDto pclmsTagsGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsTagsGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsTags with Id " + pclmsTagsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsTagsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsTagsAsync([FromBody] PclmsTagsUpdateDto pclmsTagsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsTagsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsTags with Id " + pclmsTagsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsTags>(pclmsTagsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsTagsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsTags with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsTagsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}