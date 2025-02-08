using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LmsCourseAssetsController : ControllerBase {
        private readonly ILmsCourseAssetsService _service;
        private readonly IMapper _mapper;

        public LmsCourseAssetsController(ILmsCourseAssetsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLmsCourseAssets([FromBody] LmsCourseAssetsCreateDto lmsCourseAssetsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LmsCourseAssets>(lmsCourseAssetsCreateDto));
                var displayDto = _mapper.Map<LmsCourseAssetsDisplayDto>(entity);
                return Created(nameof(CreateLmsCourseAssets), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LmsCourseAssetsGetDto lmsCourseAssetsGetDto) {
            try {
                var entity = await _service.GetAsync(lmsCourseAssetsGetDto.Id);
                if (entity == null) {
                    return NotFound("LmsCourseAssets with Id " + lmsCourseAssetsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LmsCourseAssetsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLmsCourseAssetsAsync([FromBody] LmsCourseAssetsUpdateDto lmsCourseAssetsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(lmsCourseAssetsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseAssets with Id " + lmsCourseAssetsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LmsCourseAssets>(lmsCourseAssetsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLmsCourseAssetsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LmsCourseAssets with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LmsCourseAssetsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}