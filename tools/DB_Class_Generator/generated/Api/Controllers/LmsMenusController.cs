using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsMenusController : ControllerBase {
        private readonly ILmsMenusService _service;
        private readonly IMapper _mapper;

        public LmsMenusController(ILmsMenusService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsMenus([FromBody] LmsMenusCreateDto lmsMenusCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsMenus>(lmsMenusCreateDto));
                var displayDto = _mapper.Map<LmsMenusDisplayDto>(entity);
                return Created(nameof(CreateLmsMenus), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsMenusGetDto lmsMenusGetDto) {
            try {
                var entity = await _service.GetAsync(lmsMenusGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsMenus with Id " + lmsMenusGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsMenusDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsMenusAsync([FromBody] LmsMenusUpdateDto lmsMenusUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsMenusUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsMenus with Id " + lmsMenusUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsMenus>(lmsMenusUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsMenusAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsMenus with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsMenusDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}