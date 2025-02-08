using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCourseAccountsController : ControllerBase {
        private readonly ILmsCourseAccountsService _service;
        private readonly IMapper _mapper;

        public LmsCourseAccountsController(ILmsCourseAccountsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCourseAccounts([FromBody] LmsCourseAccountsCreateDto lmsCourseAccountsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCourseAccounts>(lmsCourseAccountsCreateDto));
                var displayDto = _mapper.Map<LmsCourseAccountsDisplayDto>(entity);
                return Created(nameof(CreateLmsCourseAccounts), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCourseAccountsGetDto lmsCourseAccountsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCourseAccountsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCourseAccounts with Id " + lmsCourseAccountsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCourseAccountsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCourseAccountsAsync([FromBody] LmsCourseAccountsUpdateDto lmsCourseAccountsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCourseAccountsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseAccounts with Id " + lmsCourseAccountsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCourseAccounts>(lmsCourseAccountsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCourseAccountsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseAccounts with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCourseAccountsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}