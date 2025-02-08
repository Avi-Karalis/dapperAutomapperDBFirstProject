using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsAccountModulesController : ControllerBase {
        private readonly IPclmsAccountModulesService _service;
        private readonly IMapper _mapper;

        public PclmsAccountModulesController(IPclmsAccountModulesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsAccountModules([FromBody] PclmsAccountModulesCreateDto pclmsAccountModulesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsAccountModules>(pclmsAccountModulesCreateDto));
                var displayDto = _mapper.Map<PclmsAccountModulesDisplayDto>(entity);
                return Created(nameof(CreatePclmsAccountModules), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsAccountModulesGetDto pclmsAccountModulesGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsAccountModulesGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsAccountModules with Id " + pclmsAccountModulesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsAccountModulesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsAccountModulesAsync([FromBody] PclmsAccountModulesUpdateDto pclmsAccountModulesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsAccountModulesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsAccountModules with Id " + pclmsAccountModulesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsAccountModules>(pclmsAccountModulesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsAccountModulesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsAccountModules with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsAccountModulesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}