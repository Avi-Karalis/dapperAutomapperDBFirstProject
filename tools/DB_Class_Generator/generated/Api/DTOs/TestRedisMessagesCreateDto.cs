using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class TestRedisMessagesCreateDto : IDto {
        public string Username { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public ulong Timestamp { get; set; } = 0;
        public string Message { get; set; } = string.Empty;
        public string Room { get; set; } = string.Empty;
    }
}