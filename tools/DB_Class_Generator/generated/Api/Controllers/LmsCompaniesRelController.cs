using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCompaniesRelController : ControllerBase {
        private readonly ILmsCompaniesRelService _service;
        private readonly IMapper _mapper;

        public LmsCompaniesRelController(ILmsCompaniesRelService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCompaniesRel([FromBody] LmsCompaniesRelCreateDto lmsCompaniesRelCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCompaniesRel>(lmsCompaniesRelCreateDto));
                var displayDto = _mapper.Map<LmsCompaniesRelDisplayDto>(entity);
                return Created(nameof(CreateLmsCompaniesRel), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCompaniesRelGetDto lmsCompaniesRelGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCompaniesRelGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCompaniesRel with Id " + lmsCompaniesRelGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCompaniesRelDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCompaniesRelAsync([FromBody] LmsCompaniesRelUpdateDto lmsCompaniesRelUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCompaniesRelUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCompaniesRel with Id " + lmsCompaniesRelUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCompaniesRel>(lmsCompaniesRelUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCompaniesRelAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCompaniesRel with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCompaniesRelDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}