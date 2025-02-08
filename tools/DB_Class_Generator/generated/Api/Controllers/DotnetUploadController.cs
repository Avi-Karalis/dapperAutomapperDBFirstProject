using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class DotnetUploadController : ControllerBase {
        private readonly IDotnetUploadService _service;
        private readonly IMapper _mapper;

        public DotnetUploadController(IDotnetUploadService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateDotnetUpload([FromBody] DotnetUploadCreateDto dotnetUploadCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<DotnetUpload>(dotnetUploadCreateDto));
                var displayDto = _mapper.Map<DotnetUploadDisplayDto>(entity);
                return Created(nameof(CreateDotnetUpload), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] DotnetUploadGetDto dotnetUploadGetDto) {
            try {
                var entity = await _service.GetAsync(dotnetUploadGetDto.Id);
                if (entity == null) {
                    return NotFound("DotnetUpload with Id " + dotnetUploadGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<DotnetUploadDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateDotnetUploadAsync([FromBody] DotnetUploadUpdateDto dotnetUploadUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(dotnetUploadUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("DotnetUpload with Id " + dotnetUploadUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<DotnetUpload>(dotnetUploadUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteDotnetUploadAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("DotnetUpload with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<DotnetUploadDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}