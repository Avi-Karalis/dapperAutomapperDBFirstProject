using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CompaniesExtController : ControllerBase {
        private readonly ICompaniesExtService _service;
        private readonly IMapper _mapper;

        public CompaniesExtController(ICompaniesExtService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCompaniesExt([FromBody] CompaniesExtCreateDto companiesExtCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CompaniesExt>(companiesExtCreateDto));
                var displayDto = _mapper.Map<CompaniesExtDisplayDto>(entity);
                return Created(nameof(CreateCompaniesExt), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CompaniesExtGetDto companiesExtGetDto) {
            try {
                var entity = await _service.GetAsync(companiesExtGetDto.Id);
                if (entity == null) {
                    return NotFound("CompaniesExt with Id " + companiesExtGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CompaniesExtDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCompaniesExtAsync([FromBody] CompaniesExtUpdateDto companiesExtUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(companiesExtUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CompaniesExt with Id " + companiesExtUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CompaniesExt>(companiesExtUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCompaniesExtAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CompaniesExt with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CompaniesExtDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}