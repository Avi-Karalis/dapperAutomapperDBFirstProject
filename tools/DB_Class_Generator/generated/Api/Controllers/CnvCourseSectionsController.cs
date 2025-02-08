using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseSectionsController : ControllerBase {
        private readonly ICnvCourseSectionsService _service;
        private readonly IMapper _mapper;

        public CnvCourseSectionsController(ICnvCourseSectionsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseSections([FromBody] CnvCourseSectionsCreateDto cnvCourseSectionsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseSections>(cnvCourseSectionsCreateDto));
                var displayDto = _mapper.Map<CnvCourseSectionsDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseSections), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseSectionsGetDto cnvCourseSectionsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseSectionsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseSections with Id " + cnvCourseSectionsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseSectionsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseSectionsAsync([FromBody] CnvCourseSectionsUpdateDto cnvCourseSectionsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseSectionsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseSections with Id " + cnvCourseSectionsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseSections>(cnvCourseSectionsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseSectionsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseSections with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseSectionsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}