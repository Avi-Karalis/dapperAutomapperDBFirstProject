using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class AccountsController : ControllerBase {
        private readonly IAccountsService _service;
        private readonly IMapper _mapper;

        public AccountsController(IAccountsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateAccounts([FromBody] AccountsCreateDto accountsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<Accounts>(accountsCreateDto));
                var displayDto = _mapper.Map<AccountsDisplayDto>(entity);
                return Created(nameof(CreateAccounts), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] AccountsGetDto accountsGetDto) {
            try {
                var entity = await _service.GetAsync(accountsGetDto.Id);
                if (entity == null) {
                    return NotFound("Accounts with Id " + accountsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<AccountsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateAccountsAsync([FromBody] AccountsUpdateDto accountsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(accountsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("Accounts with Id " + accountsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<Accounts>(accountsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteAccountsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("Accounts with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<AccountsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}