using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PcTokensController : ControllerBase {
        private readonly IPcTokensService _service;
        private readonly IMapper _mapper;

        public PcTokensController(IPcTokensService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePcTokens([FromBody] PcTokensCreateDto pcTokensCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PcTokens>(pcTokensCreateDto));
                var displayDto = _mapper.Map<PcTokensDisplayDto>(entity);
                return Created(nameof(CreatePcTokens), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PcTokensGetDto pcTokensGetDto) {
            try {
                var entity = await _service.GetAsync(pcTokensGetDto.Id);
                if (entity == null) {
                    return NotFound("PcTokens with Id " + pcTokensGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PcTokensDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePcTokensAsync([FromBody] PcTokensUpdateDto pcTokensUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pcTokensUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PcTokens with Id " + pcTokensUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PcTokens>(pcTokensUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePcTokensAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PcTokens with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PcTokensDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}