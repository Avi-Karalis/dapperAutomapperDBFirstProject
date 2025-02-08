using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
namespace AdminPanel.Api.Controllers {

    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class UserController : ControllerBase {
        private readonly IUserService _service;
        private readonly IMapper _mapper;
        public UserController(IUserService service, IMapper mapper) => (_service, _mapper) = (service, mapper);

        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody]UserCreateDto userCreateDto) {
            try {
                (userCreateDto.PasswordHash, userCreateDto.Salt) = _service.HashPassword(userCreateDto.PasswordHash);
                User user = await _service.CreateAsync(_mapper.Map<User>(userCreateDto));
                UserDisplayDto userDisplayDto = _mapper.Map<UserDisplayDto>(user);
                return Created(nameof(CreateUser), userDisplayDto);
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetAsync([FromBody] UserGetDto getDto) {
            try {
                User user = await _service.GetAsync(getDto.Id);
                if (user == null) { return NotFound("User with Id" + getDto.Id + "not found:"); }
                return Ok(user);

            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateUserAsync(UserUpdateDto userUpdateDto) {
            try {
                User existingUser = await _service.GetAsync(userUpdateDto.Id);
                if (existingUser == null) {
                    return NotFound("User with id " + userUpdateDto.Id + "not found");
                }
                await _service.UpdateAsync(_mapper.Map<User>(userUpdateDto));
                return NoContent();
            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteUserAsync(ulong id) {
            try {
                User existingUser = await _service.GetAsync(id);
                if (existingUser == null) { return NotFound("User with id " + id + "not found"); }
                await _service.DeleteAsync(existingUser);
                return NoContent();

            } catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("list")]
        public async Task<IActionResult> List(QueryParameters? queryParams) {
            try {
                IEnumerable<User> users = await _service.ListAsync(queryParams);
                return Ok(users);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}