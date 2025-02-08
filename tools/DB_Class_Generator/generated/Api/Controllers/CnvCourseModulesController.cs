using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseModulesController : ControllerBase {
        private readonly ICnvCourseModulesService _service;
        private readonly IMapper _mapper;

        public CnvCourseModulesController(ICnvCourseModulesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseModules([FromBody] CnvCourseModulesCreateDto cnvCourseModulesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseModules>(cnvCourseModulesCreateDto));
                var displayDto = _mapper.Map<CnvCourseModulesDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseModules), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseModulesGetDto cnvCourseModulesGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseModulesGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseModules with Id " + cnvCourseModulesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseModulesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseModulesAsync([FromBody] CnvCourseModulesUpdateDto cnvCourseModulesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseModulesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseModules with Id " + cnvCourseModulesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseModules>(cnvCourseModulesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseModulesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseModules with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseModulesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}