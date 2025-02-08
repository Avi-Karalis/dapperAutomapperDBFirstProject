using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CacheController : ControllerBase {
        private readonly ICacheService _service;
        private readonly IMapper _mapper;

        public CacheController(ICacheService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCache([FromBody] CacheCreateDto cacheCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<Cache>(cacheCreateDto));
                var displayDto = _mapper.Map<CacheDisplayDto>(entity);
                return Created(nameof(CreateCache), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CacheGetDto cacheGetDto) {
            try {
                var entity = await _service.GetAsync(cacheGetDto.Id);
                if (entity == null) {
                    return NotFound("Cache with Id " + cacheGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CacheDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCacheAsync([FromBody] CacheUpdateDto cacheUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cacheUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("Cache with Id " + cacheUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<Cache>(cacheUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCacheAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("Cache with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CacheDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}