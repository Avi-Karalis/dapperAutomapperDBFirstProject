using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PcTokensDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string MasqUserId { get; set; } = string.Empty;
        public string ClientId { get; set; } = string.Empty;
        public string ExpiresAt { get; set; } = string.Empty;
    }
}