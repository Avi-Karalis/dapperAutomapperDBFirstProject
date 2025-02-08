using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCompanyContractsController : ControllerBase {
        private readonly ILmsCompanyContractsService _service;
        private readonly IMapper _mapper;

        public LmsCompanyContractsController(ILmsCompanyContractsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCompanyContracts([FromBody] LmsCompanyContractsCreateDto lmsCompanyContractsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCompanyContracts>(lmsCompanyContractsCreateDto));
                var displayDto = _mapper.Map<LmsCompanyContractsDisplayDto>(entity);
                return Created(nameof(CreateLmsCompanyContracts), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCompanyContractsGetDto lmsCompanyContractsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCompanyContractsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCompanyContracts with Id " + lmsCompanyContractsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCompanyContractsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCompanyContractsAsync([FromBody] LmsCompanyContractsUpdateDto lmsCompanyContractsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCompanyContractsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCompanyContracts with Id " + lmsCompanyContractsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCompanyContracts>(lmsCompanyContractsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCompanyContractsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCompanyContracts with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCompanyContractsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}