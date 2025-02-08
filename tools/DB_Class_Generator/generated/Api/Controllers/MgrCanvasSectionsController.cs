using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class MgrCanvasSectionsController : ControllerBase {
        private readonly IMgrCanvasSectionsService _service;
        private readonly IMapper _mapper;

        public MgrCanvasSectionsController(IMgrCanvasSectionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateMgrCanvasSections([FromBody] MgrCanvasSectionsCreateDto mgrCanvasSectionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<MgrCanvasSections>(mgrCanvasSectionsCreateDto));
                var displayDto = _mapper.Map<MgrCanvasSectionsDisplayDto>(entity);
                return Created(nameof(CreateMgrCanvasSections), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] MgrCanvasSectionsGetDto mgrCanvasSectionsGetDto) {
            try {
                var entity = await _service.GetAsync(mgrCanvasSectionsGetDto.Id);
                if (entity == null) {
                    return NotFound("MgrCanvasSections with Id " + mgrCanvasSectionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<MgrCanvasSectionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMgrCanvasSectionsAsync([FromBody] MgrCanvasSectionsUpdateDto mgrCanvasSectionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(mgrCanvasSectionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasSections with Id " + mgrCanvasSectionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<MgrCanvasSections>(mgrCanvasSectionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMgrCanvasSectionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("MgrCanvasSections with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<MgrCanvasSectionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}