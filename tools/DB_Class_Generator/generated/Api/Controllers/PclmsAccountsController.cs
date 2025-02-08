using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsAccountsController : ControllerBase {
        private readonly IPclmsAccountsService _service;
        private readonly IMapper _mapper;

        public PclmsAccountsController(IPclmsAccountsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsAccounts([FromBody] PclmsAccountsCreateDto pclmsAccountsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsAccounts>(pclmsAccountsCreateDto));
                var displayDto = _mapper.Map<PclmsAccountsDisplayDto>(entity);
                return Created(nameof(CreatePclmsAccounts), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsAccountsGetDto pclmsAccountsGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsAccountsGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsAccounts with Id " + pclmsAccountsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsAccountsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsAccountsAsync([FromBody] PclmsAccountsUpdateDto pclmsAccountsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsAccountsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsAccounts with Id " + pclmsAccountsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsAccounts>(pclmsAccountsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsAccountsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsAccounts with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsAccountsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}