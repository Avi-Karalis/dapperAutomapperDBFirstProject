using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsCourseModulesController : ControllerBase {
        private readonly IPclmsCourseModulesService _service;
        private readonly IMapper _mapper;

        public PclmsCourseModulesController(IPclmsCourseModulesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsCourseModules([FromBody] PclmsCourseModulesCreateDto pclmsCourseModulesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsCourseModules>(pclmsCourseModulesCreateDto));
                var displayDto = _mapper.Map<PclmsCourseModulesDisplayDto>(entity);
                return Created(nameof(CreatePclmsCourseModules), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsCourseModulesGetDto pclmsCourseModulesGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsCourseModulesGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsCourseModules with Id " + pclmsCourseModulesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsCourseModulesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsCourseModulesAsync([FromBody] PclmsCourseModulesUpdateDto pclmsCourseModulesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsCourseModulesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseModules with Id " + pclmsCourseModulesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsCourseModules>(pclmsCourseModulesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsCourseModulesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseModules with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsCourseModulesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}