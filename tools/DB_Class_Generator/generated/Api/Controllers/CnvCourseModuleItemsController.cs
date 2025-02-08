using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseModuleItemsController : ControllerBase {
        private readonly ICnvCourseModuleItemsService _service;
        private readonly IMapper _mapper;

        public CnvCourseModuleItemsController(ICnvCourseModuleItemsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseModuleItems([FromBody] CnvCourseModuleItemsCreateDto cnvCourseModuleItemsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseModuleItems>(cnvCourseModuleItemsCreateDto));
                var displayDto = _mapper.Map<CnvCourseModuleItemsDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseModuleItems), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseModuleItemsGetDto cnvCourseModuleItemsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseModuleItemsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseModuleItems with Id " + cnvCourseModuleItemsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseModuleItemsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseModuleItemsAsync([FromBody] CnvCourseModuleItemsUpdateDto cnvCourseModuleItemsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseModuleItemsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseModuleItems with Id " + cnvCourseModuleItemsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseModuleItems>(cnvCourseModuleItemsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseModuleItemsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseModuleItems with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseModuleItemsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}