using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class DotnetPersonController : ControllerBase {
        private readonly IDotnetPersonService _service;
        private readonly IMapper _mapper;

        public DotnetPersonController(IDotnetPersonService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateDotnetPerson([FromBody] DotnetPersonCreateDto dotnetPersonCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<DotnetPerson>(dotnetPersonCreateDto));
                var displayDto = _mapper.Map<DotnetPersonDisplayDto>(entity);
                return Created(nameof(CreateDotnetPerson), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] DotnetPersonGetDto dotnetPersonGetDto) {
            try {
                var entity = await _service.GetAsync(dotnetPersonGetDto.Id);
                if (entity == null) {
                    return NotFound("DotnetPerson with Id " + dotnetPersonGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<DotnetPersonDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateDotnetPersonAsync([FromBody] DotnetPersonUpdateDto dotnetPersonUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(dotnetPersonUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("DotnetPerson with Id " + dotnetPersonUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<DotnetPerson>(dotnetPersonUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteDotnetPersonAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("DotnetPerson with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<DotnetPersonDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}