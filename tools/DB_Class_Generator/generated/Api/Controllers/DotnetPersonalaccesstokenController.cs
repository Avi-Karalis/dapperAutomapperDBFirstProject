using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class DotnetPersonalaccesstokenController : ControllerBase {
        private readonly IDotnetPersonalaccesstokenService _service;
        private readonly IMapper _mapper;

        public DotnetPersonalaccesstokenController(IDotnetPersonalaccesstokenService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateDotnetPersonalaccesstoken([FromBody] DotnetPersonalaccesstokenCreateDto dotnetPersonalaccesstokenCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<DotnetPersonalaccesstoken>(dotnetPersonalaccesstokenCreateDto));
                var displayDto = _mapper.Map<DotnetPersonalaccesstokenDisplayDto>(entity);
                return Created(nameof(CreateDotnetPersonalaccesstoken), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] DotnetPersonalaccesstokenGetDto dotnetPersonalaccesstokenGetDto) {
            try {
                var entity = await _service.GetAsync(dotnetPersonalaccesstokenGetDto.Id);
                if (entity == null) {
                    return NotFound("DotnetPersonalaccesstoken with Id " + dotnetPersonalaccesstokenGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<DotnetPersonalaccesstokenDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateDotnetPersonalaccesstokenAsync([FromBody] DotnetPersonalaccesstokenUpdateDto dotnetPersonalaccesstokenUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(dotnetPersonalaccesstokenUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("DotnetPersonalaccesstoken with Id " + dotnetPersonalaccesstokenUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<DotnetPersonalaccesstoken>(dotnetPersonalaccesstokenUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteDotnetPersonalaccesstokenAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("DotnetPersonalaccesstoken with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<DotnetPersonalaccesstokenDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}