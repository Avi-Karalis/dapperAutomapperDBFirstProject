using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseFilesController : ControllerBase {
        private readonly ICnvCourseFilesService _service;
        private readonly IMapper _mapper;

        public CnvCourseFilesController(ICnvCourseFilesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseFiles([FromBody] CnvCourseFilesCreateDto cnvCourseFilesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseFiles>(cnvCourseFilesCreateDto));
                var displayDto = _mapper.Map<CnvCourseFilesDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseFiles), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseFilesGetDto cnvCourseFilesGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseFilesGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseFiles with Id " + cnvCourseFilesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseFilesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseFilesAsync([FromBody] CnvCourseFilesUpdateDto cnvCourseFilesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseFilesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseFiles with Id " + cnvCourseFilesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseFiles>(cnvCourseFilesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseFilesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseFiles with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseFilesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}