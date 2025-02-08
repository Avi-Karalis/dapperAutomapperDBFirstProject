using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class TestRedisMessagesController : ControllerBase {
        private readonly ITestRedisMessagesService _service;
        private readonly IMapper _mapper;

        public TestRedisMessagesController(ITestRedisMessagesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateTestRedisMessages([FromBody] TestRedisMessagesCreateDto testRedisMessagesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<TestRedisMessages>(testRedisMessagesCreateDto));
                var displayDto = _mapper.Map<TestRedisMessagesDisplayDto>(entity);
                return Created(nameof(CreateTestRedisMessages), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] TestRedisMessagesGetDto testRedisMessagesGetDto) {
            try {
                var entity = await _service.GetAsync(testRedisMessagesGetDto.Id);
                if (entity == null) {
                    return NotFound("TestRedisMessages with Id " + testRedisMessagesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<TestRedisMessagesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateTestRedisMessagesAsync([FromBody] TestRedisMessagesUpdateDto testRedisMessagesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(testRedisMessagesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("TestRedisMessages with Id " + testRedisMessagesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<TestRedisMessages>(testRedisMessagesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteTestRedisMessagesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("TestRedisMessages with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<TestRedisMessagesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}