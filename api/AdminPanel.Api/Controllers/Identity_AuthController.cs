using AdminPanel.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using AutoMapper;
using System;
using AdminPanel.Api.Models;
namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class Identity_AuthController : ControllerBase {
        private readonly IIdentity_TokenService _tokenService;
        private readonly IMapper _mapper;
        public Identity_AuthController(IIdentity_TokenService tokenService, IMapper mapper) => (_tokenService, _mapper) = (tokenService, mapper);

        [HttpPost("getRequesterResponse")]
        public async Task<IActionResult> getRequesterResponse (string clientId, bool dev = false) {
           if (dev == true) {
                return Ok(_tokenService.getRequesterResponse(clientId, dev));
           }
            return BadRequest("not implemented yet");
        }

        [HttpPost("checkToken")]
        public async Task<IActionResult> checkToken([FromBody] CheckTokenRequest request) {
            if (request.Dev == true) {
                RequesterResponse response = _tokenService.getRequesterResponse(request.ClientId, request.Dev);

                return Ok(await _tokenService.checkToken(response));
            }
            return BadRequest("not implemented yet");
        }

        [HttpPost("createFakeToken")]
        public async Task<IActionResult> createFakeToken([FromBody] CreateFakeToken request) {
            Random random = new();
            request.Uid ??= (ulong)random.NextInt64(0, long.MaxValue) + (ulong)random.NextInt64(0, long.MaxValue);
            request.Expires_At = _tokenService.ConvertDateTimeToUnixTimestamp(DateTime.UtcNow.AddDays(1));
            
            Token token = await _tokenService.CreateAsync(_mapper.Map<Token>(request));
            if (token != null) {
                return Ok(token);
            }
            return BadRequest("not implemented yet");
        }

        [HttpPost("impersonate")]
        public async Task<IActionResult> impersonate([FromBody] ImpersonateEnter request) {
            QueryParameters query = new() {
                Filters = new List<Filter> {
                    new () {
                        ConstraintOperator = "=",
                        Field = "user_id",
                        Value = request.User_Id
                    }
                }
            };
            Token? token =  (await _tokenService.ListAsync(query)).FirstOrDefault();
            if (token != null) {
                token.Masq_User_Id = request.IdToMasquarade;
                await _tokenService.UpdateAsync(token);
                return Ok(token.Masq_User_Id);
            }
            return BadRequest();
        }

        [HttpPost("impersonateLeave")]
        public async Task<IActionResult> impersonateLeave([FromBody] ImpersonateLeave request) {
            QueryParameters query = new() {
                Filters = new List<Filter> {
                    new () {
                        ConstraintOperator = "=",
                        Field = "user_id",
                        Value = request.User_Id
                    }
                }
            };
            Token? token = _tokenService.ListAsync(query).Result.FirstOrDefault();
            if (token != null) {
                token.Masq_User_Id = null;
                await _tokenService.UpdateAsync(token);
                return Ok(token);
            }
            return BadRequest();
        }
    }
}
