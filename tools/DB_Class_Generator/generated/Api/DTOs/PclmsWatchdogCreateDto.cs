using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsWatchdogCreateDto : IDto {
        public string Wid { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Method { get; set; } = string.Empty;
        public string Payload { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}