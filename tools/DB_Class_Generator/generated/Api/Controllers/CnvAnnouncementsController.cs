using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class CnvAnnouncementsController : ControllerBase {
        private readonly ICnvAnnouncementsService _service;
        private readonly IMapper _mapper;

        public CnvAnnouncementsController(ICnvAnnouncementsService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateCnvAnnouncements([FromBody] CnvAnnouncementsCreateDto cnvAnnouncementsCreateDto) {
            try {
                var entity = await _service.CreateAsync(_mapper.Map<CnvAnnouncements>(cnvAnnouncementsCreateDto));
                var displayDto = _mapper.Map<CnvAnnouncementsDisplayDto>(entity);
                return Created(nameof(CreateCnvAnnouncements), displayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] CnvAnnouncementsGetDto cnvAnnouncementsGetDto) {
            try {
                var entity = await _service.GetAsync(cnvAnnouncementsGetDto.Id);
                if (entity == null) {
                    return NotFound("CnvAnnouncements with Id " + cnvAnnouncementsGetDto.Id + " not found.");
                }
                return Ok(_mapper.Map<CnvAnnouncementsDisplayDto>(entity));
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCnvAnnouncementsAsync([FromBody] CnvAnnouncementsUpdateDto cnvAnnouncementsUpdateDto) {
            try {
                var existingEntity = await _service.GetAsync(cnvAnnouncementsUpdateDto.Id);
                if (existingEntity == null) {
                    return NotFound("CnvAnnouncements with Id " + cnvAnnouncementsUpdateDto.Id + " not found.");
                }
                await _service.UpdateAsync(_mapper.Map<CnvAnnouncements>(cnvAnnouncementsUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCnvAnnouncementsAsync([FromBody] ulong id) {
            try {
                var existingEntity = await _service.GetAsync(id);
                if (existingEntity == null) {
                    return NotFound("CnvAnnouncements with Id " + id + " not found.");
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
                var displayDtos = _mapper.Map<IEnumerable<CnvAnnouncementsDisplayDto>>(entities);
                return Ok(displayDtos);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}