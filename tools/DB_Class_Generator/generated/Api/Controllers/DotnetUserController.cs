using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class DotnetUserController : ControllerBase {
        private readonly IDotnetUserService _service;
        private readonly IMapper _mapper;

        public DotnetUserController(IDotnetUserService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateDotnetUser([FromBody] DotnetUserCreateDto dotnetUserCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<DotnetUser>(dotnetUserCreateDto));
                var displayDto = _mapper.Map<DotnetUserDisplayDto>(entity);
                return Created(nameof(CreateDotnetUser), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] DotnetUserGetDto dotnetUserGetDto) {
            try {
                var entity = await _service.GetAsync(dotnetUserGetDto.Id);
                if (entity == null) {
                    return NotFound("DotnetUser with Id " + dotnetUserGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<DotnetUserDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateDotnetUserAsync([FromBody] DotnetUserUpdateDto dotnetUserUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(dotnetUserUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("DotnetUser with Id " + dotnetUserUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<DotnetUser>(dotnetUserUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteDotnetUserAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("DotnetUser with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<DotnetUserDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}