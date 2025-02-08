using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsPagesController : ControllerBase {
        private readonly IPclmsPagesService _service;
        private readonly IMapper _mapper;

        public PclmsPagesController(IPclmsPagesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsPages([FromBody] PclmsPagesCreateDto pclmsPagesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsPages>(pclmsPagesCreateDto));
                var displayDto = _mapper.Map<PclmsPagesDisplayDto>(entity);
                return Created(nameof(CreatePclmsPages), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsPagesGetDto pclmsPagesGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsPagesGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsPages with Id " + pclmsPagesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsPagesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsPagesAsync([FromBody] PclmsPagesUpdateDto pclmsPagesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsPagesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsPages with Id " + pclmsPagesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsPages>(pclmsPagesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsPagesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsPages with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsPagesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}