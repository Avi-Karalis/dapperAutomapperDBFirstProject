using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsTokensUpdateDto : IDto {
        public ulong Id { get; set; } = 0;
        public string Clientid { get; set; } = string.Empty;
        public ulong UserId { get; set; } = 0;
        public ulong MasqUserId { get; set; } = 0;
        public ulong SessionExpiresAt { get; set; } = 0;
        public ulong ExpiresAt { get; set; } = 0;
        public ulong CreatedAt { get; set; } = 0;
    }
}