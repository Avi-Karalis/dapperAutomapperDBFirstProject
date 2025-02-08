using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class LanguagesController : ControllerBase {
        private readonly ILanguagesService _service;
        private readonly IMapper _mapper;

        public LanguagesController(ILanguagesService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateLanguages([FromBody] LanguagesCreateDto languagesCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<Languages>(languagesCreateDto));
                var displayDto = _mapper.Map<LanguagesDisplayDto>(entity);
                return Created(nameof(CreateLanguages), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] LanguagesGetDto languagesGetDto) {
            try {
                var entity = await _service.GetAsync(languagesGetDto.Id);
                if (entity == null) {
                    return NotFound("Languages with Id " + languagesGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<LanguagesDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLanguagesAsync([FromBody] LanguagesUpdateDto languagesUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(languagesUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("Languages with Id " + languagesUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<Languages>(languagesUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLanguagesAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("Languages with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<LanguagesDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}