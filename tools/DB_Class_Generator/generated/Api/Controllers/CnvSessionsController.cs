using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvSessionsController : ControllerBase {
        private readonly ICnvSessionsService _service;
        private readonly IMapper _mapper;

        public CnvSessionsController(ICnvSessionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvSessions([FromBody] CnvSessionsCreateDto cnvSessionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvSessions>(cnvSessionsCreateDto));
                var displayDto = _mapper.Map<CnvSessionsDisplayDto>(entity);
                return Created(nameof(CreateCnvSessions), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvSessionsGetDto cnvSessionsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvSessionsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvSessions with Id " + cnvSessionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvSessionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvSessionsAsync([FromBody] CnvSessionsUpdateDto cnvSessionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvSessionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvSessions with Id " + cnvSessionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvSessions>(cnvSessionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvSessionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvSessions with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvSessionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}