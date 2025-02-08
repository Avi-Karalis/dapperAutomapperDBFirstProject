using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvSubAccountsController : ControllerBase {
        private readonly ICnvSubAccountsService _service;
        private readonly IMapper _mapper;

        public CnvSubAccountsController(ICnvSubAccountsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvSubAccounts([FromBody] CnvSubAccountsCreateDto cnvSubAccountsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvSubAccounts>(cnvSubAccountsCreateDto));
                var displayDto = _mapper.Map<CnvSubAccountsDisplayDto>(entity);
                return Created(nameof(CreateCnvSubAccounts), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvSubAccountsGetDto cnvSubAccountsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvSubAccountsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvSubAccounts with Id " + cnvSubAccountsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvSubAccountsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvSubAccountsAsync([FromBody] CnvSubAccountsUpdateDto cnvSubAccountsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvSubAccountsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvSubAccounts with Id " + cnvSubAccountsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvSubAccounts>(cnvSubAccountsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvSubAccountsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvSubAccounts with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvSubAccountsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}