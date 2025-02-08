using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CompaniesController : ControllerBase {
        private readonly ICompaniesService _service;
        private readonly IMapper _mapper;

        public CompaniesController(ICompaniesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCompanies([FromBody] CompaniesCreateDto companiesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<Companies>(companiesCreateDto));
                var displayDto = _mapper.Map<CompaniesDisplayDto>(entity);
                return Created(nameof(CreateCompanies), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CompaniesGetDto companiesGetDto) {
            try {
                var entity = await _service.GetAsync(companiesGetDto.Id);
                if (entity == null) {
                    return NotFound("Companies with Id " + companiesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CompaniesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCompaniesAsync([FromBody] CompaniesUpdateDto companiesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(companiesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("Companies with Id " + companiesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<Companies>(companiesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCompaniesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("Companies with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CompaniesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}