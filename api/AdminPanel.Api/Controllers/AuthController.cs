using AdminPanel.Api.Models;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class AuthController : ControllerBase {

        private readonly IAuthService _authService;
        private readonly IUserService _userService;

        public AuthController(IAuthService authService, IUserService userService) {
            _authService = authService;
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request) {
            QueryParameters query = new() {
                Filters = new List<Filter> {
                    new () {
                        ConstraintOperator = "=",
                        Field = "email",
                        Value = request.Email 
                    }
                }
            };

            User user = _userService.ListAsync(query).Result.First();

            if (_userService.ValidatePassword(user, request.Password)) {
                string accessToken = await _authService.GenerateJwtToken(user);
                string refreshToken = _authService.GenerateRefreshToken();

                PersonalAccessToken _accessToken =  await _authService.SaveTokenAsync(user.Id, accessToken, TokenTypeEnum.AccessToken);
                PersonalAccessToken _refreshToken = await _authService.SaveTokenAsync(user.Id, refreshToken, TokenTypeEnum.RefreshToken);
                return Ok(
                    new { 
                        AccessToken = _accessToken,
                        RefreshToken = _refreshToken 
                    }
                );
            }
            return Unauthorized("invalid credentials");
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromHeader] RefreshRequest request) {
            PersonalAccessToken refreshToken = await _authService.GetTokenAsync(request.RefreshToken, TokenTypeEnum.RefreshToken);
            if (refreshToken != null ||
                DateTimeOffset.FromUnixTimeSeconds((long)refreshToken.ExpiresAt).UtcDateTime > DateTime.UtcNow) {
                    QueryParameters query = new() {
                        Filters = new List<Filter>() {
                             new Filter() {
                                ConstraintOperator = "=",
                                Field = "Id",
                                Value = refreshToken.UserId
                             }
                        }
                    };
                    User user = _userService.ListAsync(query).Result.First();
                string newAccessToken = await _authService.GenerateJwtToken(user);
            }
            return Unauthorized("Invalid or expired Refresh Token");
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout([FromHeader(Name = "AccessToken")]string accessToken, [FromHeader(Name = "RefreshToken")]string refreshToken) {
            QueryParameters queryRefr = new() {
                Filters = new List<Filter>() {
                    new Filter(){ConstraintOperator = "=", Field = "Token", Value = refreshToken}
                }
            };
            QueryParameters queryAccess = new() {
                Filters = new List<Filter>() {
                    new Filter(){ConstraintOperator = "=", Field = "Token", Value = accessToken}
                }
            };
            PersonalAccessToken _accessToken = _authService.ListAsync(queryAccess).Result.First();
            PersonalAccessToken _refreshToken = _authService.ListAsync(queryRefr).Result.First();
            await _authService.RevokeTokenAsync(_accessToken);
            await _authService.RevokeTokenAsync(_refreshToken);
            return Ok("Logged out");
        }
    }   
}
