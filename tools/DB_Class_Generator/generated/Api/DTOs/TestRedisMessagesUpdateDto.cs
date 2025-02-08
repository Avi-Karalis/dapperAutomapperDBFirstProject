using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class TestRedisMessagesUpdateDto : IDto {
        public int Id { get; set; } = 0;
        public string Username { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public ulong Timestamp { get; set; } = 0;
        public string Message { get; set; } = string.Empty;
        public string Room { get; set; } = string.Empty;
    }
}