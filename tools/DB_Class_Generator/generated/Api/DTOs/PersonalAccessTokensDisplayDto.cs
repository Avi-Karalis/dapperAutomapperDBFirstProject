using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PersonalAccessTokensDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string TokenableType { get; set; } = string.Empty;
        public string TokenableId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
        public string Abilities { get; set; } = string.Empty;
        public DateTime LastUsedAt { get; set; } = null;
        public DateTime ExpiresAt { get; set; } = null;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
        public string Clientid { get; set; } = string.Empty;
        public string Meta { get; set; } = string.Empty;
    }
}