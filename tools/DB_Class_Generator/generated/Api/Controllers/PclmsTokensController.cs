using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsTokensController : ControllerBase {
        private readonly IPclmsTokensService _service;
        private readonly IMapper _mapper;

        public PclmsTokensController(IPclmsTokensService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsTokens([FromBody] PclmsTokensCreateDto pclmsTokensCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsTokens>(pclmsTokensCreateDto));
                var displayDto = _mapper.Map<PclmsTokensDisplayDto>(entity);
                return Created(nameof(CreatePclmsTokens), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsTokensGetDto pclmsTokensGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsTokensGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsTokens with Id " + pclmsTokensGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsTokensDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsTokensAsync([FromBody] PclmsTokensUpdateDto pclmsTokensUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsTokensUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsTokens with Id " + pclmsTokensUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsTokens>(pclmsTokensUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsTokensAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsTokens with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsTokensDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}