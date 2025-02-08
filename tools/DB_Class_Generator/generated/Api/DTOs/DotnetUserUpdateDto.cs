using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class DotnetUserUpdateDto : IDto {
        public int Id { get; set; } = 0;
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = null;
        public string Salt { get; set; } = string.Empty;
    }
}