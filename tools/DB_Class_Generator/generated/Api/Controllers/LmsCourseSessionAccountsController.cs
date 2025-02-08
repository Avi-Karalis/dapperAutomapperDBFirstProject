using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCourseSessionAccountsController : ControllerBase {
        private readonly ILmsCourseSessionAccountsService _service;
        private readonly IMapper _mapper;

        public LmsCourseSessionAccountsController(ILmsCourseSessionAccountsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCourseSessionAccounts([FromBody] LmsCourseSessionAccountsCreateDto lmsCourseSessionAccountsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCourseSessionAccounts>(lmsCourseSessionAccountsCreateDto));
                var displayDto = _mapper.Map<LmsCourseSessionAccountsDisplayDto>(entity);
                return Created(nameof(CreateLmsCourseSessionAccounts), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCourseSessionAccountsGetDto lmsCourseSessionAccountsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCourseSessionAccountsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCourseSessionAccounts with Id " + lmsCourseSessionAccountsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCourseSessionAccountsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCourseSessionAccountsAsync([FromBody] LmsCourseSessionAccountsUpdateDto lmsCourseSessionAccountsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCourseSessionAccountsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseSessionAccounts with Id " + lmsCourseSessionAccountsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCourseSessionAccounts>(lmsCourseSessionAccountsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCourseSessionAccountsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseSessionAccounts with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCourseSessionAccountsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}