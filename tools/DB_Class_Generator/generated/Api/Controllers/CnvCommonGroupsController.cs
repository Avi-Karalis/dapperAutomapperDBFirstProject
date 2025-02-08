using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCommonGroupsController : ControllerBase {
        private readonly ICnvCommonGroupsService _service;
        private readonly IMapper _mapper;

        public CnvCommonGroupsController(ICnvCommonGroupsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCommonGroups([FromBody] CnvCommonGroupsCreateDto cnvCommonGroupsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCommonGroups>(cnvCommonGroupsCreateDto));
                var displayDto = _mapper.Map<CnvCommonGroupsDisplayDto>(entity);
                return Created(nameof(CreateCnvCommonGroups), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCommonGroupsGetDto cnvCommonGroupsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCommonGroupsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCommonGroups with Id " + cnvCommonGroupsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCommonGroupsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCommonGroupsAsync([FromBody] CnvCommonGroupsUpdateDto cnvCommonGroupsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCommonGroupsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCommonGroups with Id " + cnvCommonGroupsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCommonGroups>(cnvCommonGroupsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCommonGroupsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCommonGroups with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCommonGroupsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}