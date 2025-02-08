using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AdminPanel.Service.Services {
    public class AuthService : CrudService<PersonalAccessToken>, IAuthService {
        private readonly IConfiguration _configuration;
        public AuthService(IPersonalAccessTokenRepository repository, IConfiguration configuration) : base(repository) {
            _configuration = configuration;
        }

        public async Task<string> GenerateJwtToken(User user) {
            SymmetricSecurityKey securityKey = new (Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            SigningCredentials credentials = new(securityKey, SecurityAlgorithms.HmacSha256);

            Claim[] claims =  [
                new (JwtRegisteredClaimNames.Sub, user.Username),
                new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new (ClaimTypes.NameIdentifier, user.Id.ToString())
            ];

            JwtSecurityToken token = new(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:ExpiryInMinutes"])),
                    signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        public string GenerateRefreshToken() => Guid.NewGuid().ToString();

        public async Task<PersonalAccessToken> SaveTokenAsync(ulong userId, string tokenValue, TokenTypeEnum type) {
            PersonalAccessToken token = new () { 
                Token = tokenValue, 
                Type = type,
                ExpiresAt = type == TokenTypeEnum.AccessToken ?
                   (ulong)new DateTimeOffset(DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:ExpiryInMinutes"]))).ToUnixTimeSeconds() :
                   (ulong)new DateTimeOffset(DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:RefreshTokenExpiryInMinutes"]))).ToUnixTimeSeconds(),
                UserId = userId
            };
            return await _repository.CreateAsync(token);
        }

        public ClaimsPrincipal ValidateToken(string token) {
            JwtSecurityTokenHandler handler = new ();
            byte[] key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
            TokenValidationParameters validationParameters = new () {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = _configuration["Jwt:Issuer"],
                ValidAudience = _configuration["Jwt:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };
            return handler.ValidateToken(token, validationParameters, out _);
        }

        public async Task<PersonalAccessToken> GetTokenAsync(string tokenValue, TokenTypeEnum type) {
            QueryParameters query = new() {
                Filters = new List<Filter> {
                    new Filter() {
                        ConstraintOperator = "=",
                        Field = "Token",
                        Value = tokenValue
                    },
                    new Filter() {
                        ConstraintOperator = "=",
                        Field = "type",
                        Value = type
                    }
                }
            };
            return _repository.ListAsync(query).Result.First();
        }

        public async Task RevokeTokenAsync(PersonalAccessToken token) {
            await _repository.DeleteAsync(token);
        }
    }
}
