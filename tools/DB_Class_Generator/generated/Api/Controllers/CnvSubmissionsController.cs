using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvSubmissionsController : ControllerBase {
        private readonly ICnvSubmissionsService _service;
        private readonly IMapper _mapper;

        public CnvSubmissionsController(ICnvSubmissionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvSubmissions([FromBody] CnvSubmissionsCreateDto cnvSubmissionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvSubmissions>(cnvSubmissionsCreateDto));
                var displayDto = _mapper.Map<CnvSubmissionsDisplayDto>(entity);
                return Created(nameof(CreateCnvSubmissions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvSubmissionsGetDto cnvSubmissionsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvSubmissionsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvSubmissions with Id " + cnvSubmissionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvSubmissionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvSubmissionsAsync([FromBody] CnvSubmissionsUpdateDto cnvSubmissionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvSubmissionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvSubmissions with Id " + cnvSubmissionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvSubmissions>(cnvSubmissionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvSubmissionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvSubmissions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvSubmissionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}