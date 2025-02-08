using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsAccountsNsController : ControllerBase {
        private readonly IPclmsAccountsNsService _service;
        private readonly IMapper _mapper;

        public PclmsAccountsNsController(IPclmsAccountsNsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsAccountsNs([FromBody] PclmsAccountsNsCreateDto pclmsAccountsNsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsAccountsNs>(pclmsAccountsNsCreateDto));
                var displayDto = _mapper.Map<PclmsAccountsNsDisplayDto>(entity);
                return Created(nameof(CreatePclmsAccountsNs), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsAccountsNsGetDto pclmsAccountsNsGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsAccountsNsGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsAccountsNs with Id " + pclmsAccountsNsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsAccountsNsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsAccountsNsAsync([FromBody] PclmsAccountsNsUpdateDto pclmsAccountsNsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsAccountsNsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsAccountsNs with Id " + pclmsAccountsNsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsAccountsNs>(pclmsAccountsNsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsAccountsNsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsAccountsNs with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsAccountsNsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}