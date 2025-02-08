using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCourseSessionAccountTransactionsController : ControllerBase {
        private readonly ILmsCourseSessionAccountTransactionsService _service;
        private readonly IMapper _mapper;

        public LmsCourseSessionAccountTransactionsController(ILmsCourseSessionAccountTransactionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCourseSessionAccountTransactions([FromBody] LmsCourseSessionAccountTransactionsCreateDto lmsCourseSessionAccountTransactionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCourseSessionAccountTransactions>(lmsCourseSessionAccountTransactionsCreateDto));
                var displayDto = _mapper.Map<LmsCourseSessionAccountTransactionsDisplayDto>(entity);
                return Created(nameof(CreateLmsCourseSessionAccountTransactions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCourseSessionAccountTransactionsGetDto lmsCourseSessionAccountTransactionsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCourseSessionAccountTransactionsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCourseSessionAccountTransactions with Id " + lmsCourseSessionAccountTransactionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCourseSessionAccountTransactionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCourseSessionAccountTransactionsAsync([FromBody] LmsCourseSessionAccountTransactionsUpdateDto lmsCourseSessionAccountTransactionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCourseSessionAccountTransactionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseSessionAccountTransactions with Id " + lmsCourseSessionAccountTransactionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCourseSessionAccountTransactions>(lmsCourseSessionAccountTransactionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCourseSessionAccountTransactionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseSessionAccountTransactions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCourseSessionAccountTransactionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}