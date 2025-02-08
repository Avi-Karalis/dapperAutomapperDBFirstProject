using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PersonalAccessTokensController : ControllerBase {
        private readonly IPersonalAccessTokensService _service;
        private readonly IMapper _mapper;

        public PersonalAccessTokensController(IPersonalAccessTokensService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePersonalAccessTokens([FromBody] PersonalAccessTokensCreateDto personalAccessTokensCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<PersonalAccessTokens>(personalAccessTokensCreateDto));
                var displayDto = _mapper.Map<PersonalAccessTokensDisplayDto>(entity);
                return Created(nameof(CreatePersonalAccessTokens), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PersonalAccessTokensGetDto personalAccessTokensGetDto) {
            try {
                var entity = await _service.GetAsync(personalAccessTokensGetDto.Id);
                if (entity == null) {
                    return NotFound("PersonalAccessTokens with Id " + personalAccessTokensGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<PersonalAccessTokensDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePersonalAccessTokensAsync([FromBody] PersonalAccessTokensUpdateDto personalAccessTokensUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(personalAccessTokensUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("PersonalAccessTokens with Id " + personalAccessTokensUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<PersonalAccessTokens>(personalAccessTokensUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePersonalAccessTokensAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("PersonalAccessTokens with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<PersonalAccessTokensDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}