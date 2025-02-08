using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseSettingsController : ControllerBase {
        private readonly ICnvCourseSettingsService _service;
        private readonly IMapper _mapper;

        public CnvCourseSettingsController(ICnvCourseSettingsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseSettings([FromBody] CnvCourseSettingsCreateDto cnvCourseSettingsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseSettings>(cnvCourseSettingsCreateDto));
                var displayDto = _mapper.Map<CnvCourseSettingsDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseSettings), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseSettingsGetDto cnvCourseSettingsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseSettingsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseSettings with Id " + cnvCourseSettingsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseSettingsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseSettingsAsync([FromBody] CnvCourseSettingsUpdateDto cnvCourseSettingsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseSettingsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseSettings with Id " + cnvCourseSettingsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseSettings>(cnvCourseSettingsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseSettingsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseSettings with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseSettingsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}