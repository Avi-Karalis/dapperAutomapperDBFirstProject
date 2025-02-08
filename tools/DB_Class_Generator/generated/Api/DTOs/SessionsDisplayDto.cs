using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class SessionsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;
        public string UserAgent { get; set; } = string.Empty;
        public string Payload { get; set; } = string.Empty;
        public int LastActivity { get; set; } = 0;
    }
}