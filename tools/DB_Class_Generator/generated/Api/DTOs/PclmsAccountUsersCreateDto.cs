using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsAccountUsersCreateDto : IDto {
        public string AccountId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}