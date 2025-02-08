using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCourseTransactionsController : ControllerBase {
        private readonly ILmsCourseTransactionsService _service;
        private readonly IMapper _mapper;

        public LmsCourseTransactionsController(ILmsCourseTransactionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCourseTransactions([FromBody] LmsCourseTransactionsCreateDto lmsCourseTransactionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCourseTransactions>(lmsCourseTransactionsCreateDto));
                var displayDto = _mapper.Map<LmsCourseTransactionsDisplayDto>(entity);
                return Created(nameof(CreateLmsCourseTransactions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCourseTransactionsGetDto lmsCourseTransactionsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCourseTransactionsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCourseTransactions with Id " + lmsCourseTransactionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCourseTransactionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCourseTransactionsAsync([FromBody] LmsCourseTransactionsUpdateDto lmsCourseTransactionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCourseTransactionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseTransactions with Id " + lmsCourseTransactionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCourseTransactions>(lmsCourseTransactionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCourseTransactionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseTransactions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCourseTransactionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}