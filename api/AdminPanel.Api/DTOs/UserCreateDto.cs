namespace AdminPanel.Api.DTOs {
    public class UserCreateDto : IDto {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? Salt { get; set; }
    }
}
