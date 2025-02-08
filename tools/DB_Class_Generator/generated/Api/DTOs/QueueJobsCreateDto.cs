using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class QueueJobsCreateDto : IDto {
        public string Queue { get; set; } = string.Empty;
        public string Payload { get; set; } = string.Empty;
        public string Attempts { get; set; } = string.Empty;
        public string ReservedAt { get; set; } = string.Empty;
        public string AvailableAt { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
    }
}