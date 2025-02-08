using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsSettingsController : ControllerBase {
        private readonly IPclmsSettingsService _service;
        private readonly IMapper _mapper;

        public PclmsSettingsController(IPclmsSettingsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsSettings([FromBody] PclmsSettingsCreateDto pclmsSettingsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsSettings>(pclmsSettingsCreateDto));
                var displayDto = _mapper.Map<PclmsSettingsDisplayDto>(entity);
                return Created(nameof(CreatePclmsSettings), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsSettingsGetDto pclmsSettingsGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsSettingsGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsSettings with Id " + pclmsSettingsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsSettingsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsSettingsAsync([FromBody] PclmsSettingsUpdateDto pclmsSettingsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsSettingsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsSettings with Id " + pclmsSettingsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsSettings>(pclmsSettingsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsSettingsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsSettings with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsSettingsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}