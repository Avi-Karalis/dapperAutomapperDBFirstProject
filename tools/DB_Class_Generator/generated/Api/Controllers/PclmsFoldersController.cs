using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsFoldersController : ControllerBase {
        private readonly IPclmsFoldersService _service;
        private readonly IMapper _mapper;

        public PclmsFoldersController(IPclmsFoldersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsFolders([FromBody] PclmsFoldersCreateDto pclmsFoldersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsFolders>(pclmsFoldersCreateDto));
                var displayDto = _mapper.Map<PclmsFoldersDisplayDto>(entity);
                return Created(nameof(CreatePclmsFolders), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsFoldersGetDto pclmsFoldersGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsFoldersGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsFolders with Id " + pclmsFoldersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsFoldersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsFoldersAsync([FromBody] PclmsFoldersUpdateDto pclmsFoldersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsFoldersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsFolders with Id " + pclmsFoldersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsFolders>(pclmsFoldersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsFoldersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsFolders with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsFoldersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}