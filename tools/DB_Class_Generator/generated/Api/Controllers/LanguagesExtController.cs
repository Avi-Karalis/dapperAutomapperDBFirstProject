using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LanguagesExtController : ControllerBase {
        private readonly ILanguagesExtService _service;
        private readonly IMapper _mapper;

        public LanguagesExtController(ILanguagesExtService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLanguagesExt([FromBody] LanguagesExtCreateDto languagesExtCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<LanguagesExt>(languagesExtCreateDto));
                var displayDto = _mapper.Map<LanguagesExtDisplayDto>(entity);
                return Created(nameof(CreateLanguagesExt), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LanguagesExtGetDto languagesExtGetDto) {
            try {
                var entity = await _service.GetAsync(languagesExtGetDto.Id);
                if (entity == null) {
                    return NotFound("LanguagesExt with Id " + languagesExtGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LanguagesExtDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLanguagesExtAsync([FromBody] LanguagesExtUpdateDto languagesExtUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(languagesExtUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("LanguagesExt with Id " + languagesExtUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<LanguagesExt>(languagesExtUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLanguagesExtAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("LanguagesExt with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LanguagesExtDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}