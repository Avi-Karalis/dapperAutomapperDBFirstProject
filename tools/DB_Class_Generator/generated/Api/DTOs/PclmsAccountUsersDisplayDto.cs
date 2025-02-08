using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsAccountUsersDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public UserIdDisplayDto? UserId { get; set; }
    }
}