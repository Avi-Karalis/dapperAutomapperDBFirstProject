using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CacheLocksController : ControllerBase {
        private readonly ICacheLocksService _service;
        private readonly IMapper _mapper;

        public CacheLocksController(ICacheLocksService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCacheLocks([FromBody] CacheLocksCreateDto cacheLocksCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CacheLocks>(cacheLocksCreateDto));
                var displayDto = _mapper.Map<CacheLocksDisplayDto>(entity);
                return Created(nameof(CreateCacheLocks), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CacheLocksGetDto cacheLocksGetDto) {
            try {
                var entity = await _service.GetAsync(cacheLocksGetDto.Id);
                if (entity == null) {
                    return NotFound("CacheLocks with Id " + cacheLocksGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CacheLocksDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCacheLocksAsync([FromBody] CacheLocksUpdateDto cacheLocksUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cacheLocksUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CacheLocks with Id " + cacheLocksUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CacheLocks>(cacheLocksUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCacheLocksAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CacheLocks with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CacheLocksDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}