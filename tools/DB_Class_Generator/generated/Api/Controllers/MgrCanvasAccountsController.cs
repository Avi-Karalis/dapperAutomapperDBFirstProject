using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasAccountsController : ControllerBase {
        private readonly IMgrCanvasAccountsService _service;
        private readonly IMapper _mapper;

        public MgrCanvasAccountsController(IMgrCanvasAccountsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasAccounts([FromBody] MgrCanvasAccountsCreateDto mgrCanvasAccountsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasAccounts>(mgrCanvasAccountsCreateDto));
                var displayDto = _mapper.Map<MgrCanvasAccountsDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasAccounts), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasAccountsGetDto mgrCanvasAccountsGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasAccountsGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasAccounts with Id " + mgrCanvasAccountsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasAccountsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasAccountsAsync([FromBody] MgrCanvasAccountsUpdateDto mgrCanvasAccountsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasAccountsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasAccounts with Id " + mgrCanvasAccountsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasAccounts>(mgrCanvasAccountsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasAccountsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasAccounts with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasAccountsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}