using AdminPanel.ModelsAndRepository.Models;
using System.Security.Claims;

namespace AdminPanel.Service.Interfaces {
    public interface IAuthService : ICrudService<PersonalAccessToken> {
        public Task<string> GenerateJwtToken(User user);
        public string GenerateRefreshToken();
        public Task<PersonalAccessToken> SaveTokenAsync(ulong userId, string tokenValue, TokenTypeEnum type);
        public ClaimsPrincipal ValidateToken(string token);
        public Task<PersonalAccessToken> GetTokenAsync(string tokenValue, TokenTypeEnum type);
        public Task RevokeTokenAsync(PersonalAccessToken token);
    }
}
