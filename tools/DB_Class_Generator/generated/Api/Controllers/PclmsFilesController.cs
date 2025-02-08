using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsFilesController : ControllerBase {
        private readonly IPclmsFilesService _service;
        private readonly IMapper _mapper;

        public PclmsFilesController(IPclmsFilesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsFiles([FromBody] PclmsFilesCreateDto pclmsFilesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsFiles>(pclmsFilesCreateDto));
                var displayDto = _mapper.Map<PclmsFilesDisplayDto>(entity);
                return Created(nameof(CreatePclmsFiles), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsFilesGetDto pclmsFilesGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsFilesGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsFiles with Id " + pclmsFilesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsFilesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsFilesAsync([FromBody] PclmsFilesUpdateDto pclmsFilesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsFilesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsFiles with Id " + pclmsFilesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsFiles>(pclmsFilesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsFilesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsFiles with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsFilesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}