namespace AdminPanel.Api.DTOs {
    public class UserUpdateDto :IDto {
        public ulong Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
