using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PclmsCourseSectionsController : ControllerBase {
        private readonly IPclmsCourseSectionsService _service;
        private readonly IMapper _mapper;

        public PclmsCourseSectionsController(IPclmsCourseSectionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePclmsCourseSections([FromBody] PclmsCourseSectionsCreateDto pclmsCourseSectionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PclmsCourseSections>(pclmsCourseSectionsCreateDto));
                var displayDto = _mapper.Map<PclmsCourseSectionsDisplayDto>(entity);
                return Created(nameof(CreatePclmsCourseSections), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PclmsCourseSectionsGetDto pclmsCourseSectionsGetDto) {
            try {
                var entity = await _service.GetAsync(pclmsCourseSectionsGetDto.Id);
                if (entity == null) {
                    return NotFound("PclmsCourseSections with Id " + pclmsCourseSectionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PclmsCourseSectionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePclmsCourseSectionsAsync([FromBody] PclmsCourseSectionsUpdateDto pclmsCourseSectionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(pclmsCourseSectionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseSections with Id " + pclmsCourseSectionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PclmsCourseSections>(pclmsCourseSectionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePclmsCourseSectionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PclmsCourseSections with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PclmsCourseSectionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}