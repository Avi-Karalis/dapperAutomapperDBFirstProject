using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseTabsController : ControllerBase {
        private readonly ICnvCourseTabsService _service;
        private readonly IMapper _mapper;

        public CnvCourseTabsController(ICnvCourseTabsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseTabs([FromBody] CnvCourseTabsCreateDto cnvCourseTabsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseTabs>(cnvCourseTabsCreateDto));
                var displayDto = _mapper.Map<CnvCourseTabsDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseTabs), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseTabsGetDto cnvCourseTabsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseTabsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseTabs with Id " + cnvCourseTabsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseTabsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseTabsAsync([FromBody] CnvCourseTabsUpdateDto cnvCourseTabsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseTabsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseTabs with Id " + cnvCourseTabsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseTabs>(cnvCourseTabsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseTabsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseTabs with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseTabsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}