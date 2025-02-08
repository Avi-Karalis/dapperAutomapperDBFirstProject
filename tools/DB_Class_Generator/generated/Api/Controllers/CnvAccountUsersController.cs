using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvAccountUsersController : ControllerBase {
        private readonly ICnvAccountUsersService _service;
        private readonly IMapper _mapper;

        public CnvAccountUsersController(ICnvAccountUsersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvAccountUsers([FromBody] CnvAccountUsersCreateDto cnvAccountUsersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvAccountUsers>(cnvAccountUsersCreateDto));
                var displayDto = _mapper.Map<CnvAccountUsersDisplayDto>(entity);
                return Created(nameof(CreateCnvAccountUsers), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvAccountUsersGetDto cnvAccountUsersGetDto) {
            try {
                var entity = await _service.GetAsync(cnvAccountUsersGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvAccountUsers with Id " + cnvAccountUsersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvAccountUsersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvAccountUsersAsync([FromBody] CnvAccountUsersUpdateDto cnvAccountUsersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvAccountUsersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvAccountUsers with Id " + cnvAccountUsersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvAccountUsers>(cnvAccountUsersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvAccountUsersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvAccountUsers with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvAccountUsersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}