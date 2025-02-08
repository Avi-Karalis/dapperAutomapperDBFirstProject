using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CompanyUsersController : ControllerBase {
        private readonly ICompanyUsersService _service;
        private readonly IMapper _mapper;

        public CompanyUsersController(ICompanyUsersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCompanyUsers([FromBody] CompanyUsersCreateDto companyUsersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CompanyUsers>(companyUsersCreateDto));
                var displayDto = _mapper.Map<CompanyUsersDisplayDto>(entity);
                return Created(nameof(CreateCompanyUsers), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CompanyUsersGetDto companyUsersGetDto) {
            try {
                var entity = await _service.GetAsync(companyUsersGetDto.Id);
                if (entity == null) {
                    return NotFound("CompanyUsers with Id " + companyUsersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CompanyUsersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCompanyUsersAsync([FromBody] CompanyUsersUpdateDto companyUsersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(companyUsersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CompanyUsers with Id " + companyUsersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CompanyUsers>(companyUsersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCompanyUsersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CompanyUsers with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CompanyUsersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}