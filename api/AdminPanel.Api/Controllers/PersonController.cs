using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
using System.Collections.Generic;
namespace AdminPanel.Api.Controllers {

    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class PersonController:ControllerBase{
        private readonly IPersonService _service;
        private readonly IMapper _mapper;
        public PersonController(IPersonService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreatePerson(PersonCreateDto personCreateDto){
            try{
                Person person = await _service.CreateAsync(_mapper.Map<Person>(personCreateDto));
                PersonDisplayDto personDisplayDto = _mapper.Map<PersonDisplayDto>(person);
                return Created(nameof(CreatePerson), personDisplayDto);
            } catch (Exception ex){
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
       
        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] PersonGetDto getDto){
            try {
                Person person = await _service.GetAsync(getDto.Id);
                if (person == null) { return NotFound("Person with Id" + getDto.Id + "not found:"); }
                return Ok(person);

            } catch (Exception ex){
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePersonAsync(PersonUpdateDto personUpdateDto) {
            try {
                Person existingPerson = await _service.GetAsync(personUpdateDto.Id);
                if (existingPerson == null){
                    return NotFound("Person with id " + personUpdateDto.Id + "not found");
                }
                await _service.UpdateAsync(_mapper.Map<Person>(personUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePersonAsync(ulong id){
            try {
                PersonDisplayDto existingPerson = _mapper.Map<PersonDisplayDto>(await _service.GetAsync(id));
                if (existingPerson == null) { return NotFound("Person with id " + id + "not found"); }
                await _service.DeleteAsync(_mapper.Map<Person>(existingPerson));
                return NoContent();

            }catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        
        [HttpPost("list")]
        public async Task<IActionResult> List([FromBody]QueryParameters? queryParams) {
            try {
                IEnumerable<PersonDisplayDto> people = _mapper.Map<IEnumerable<PersonDisplayDto>>(await _service.ListAsync(queryParams));
                return Ok(people);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}