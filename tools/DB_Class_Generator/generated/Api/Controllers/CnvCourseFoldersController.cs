using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvCourseFoldersController : ControllerBase {
        private readonly ICnvCourseFoldersService _service;
        private readonly IMapper _mapper;

        public CnvCourseFoldersController(ICnvCourseFoldersService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvCourseFolders([FromBody] CnvCourseFoldersCreateDto cnvCourseFoldersCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvCourseFolders>(cnvCourseFoldersCreateDto));
                var displayDto = _mapper.Map<CnvCourseFoldersDisplayDto>(entity);
                return Created(nameof(CreateCnvCourseFolders), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvCourseFoldersGetDto cnvCourseFoldersGetDto) {
            try {
                var entity = await _service.GetAsync(cnvCourseFoldersGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvCourseFolders with Id " + cnvCourseFoldersGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvCourseFoldersDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvCourseFoldersAsync([FromBody] CnvCourseFoldersUpdateDto cnvCourseFoldersUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvCourseFoldersUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseFolders with Id " + cnvCourseFoldersUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvCourseFolders>(cnvCourseFoldersUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvCourseFoldersAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvCourseFolders with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvCourseFoldersDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}