using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsAccountsBckController : ControllerBase {
        private readonly IPclmsAccountsBckService _service;
        private readonly IMapper _mapper;

        public PclmsAccountsBckController(IPclmsAccountsBckService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsAccountsBck([FromBody] PclmsAccountsBckCreateDto pclmsAccountsBckCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsAccountsBck>(pclmsAccountsBckCreateDto));
                var displayDto = _mapper.Map<PclmsAccountsBckDisplayDto>(entity);
                return Created(nameof(CreatePclmsAccountsBck), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsAccountsBckGetDto pclmsAccountsBckGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsAccountsBckGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsAccountsBck with Id " + pclmsAccountsBckGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsAccountsBckDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsAccountsBckAsync([FromBody] PclmsAccountsBckUpdateDto pclmsAccountsBckUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsAccountsBckUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsAccountsBck with Id " + pclmsAccountsBckUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsAccountsBck>(pclmsAccountsBckUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsAccountsBckAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsAccountsBck with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsAccountsBckDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}