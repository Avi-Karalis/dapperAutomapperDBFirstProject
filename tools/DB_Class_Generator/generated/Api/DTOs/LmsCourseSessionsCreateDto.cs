using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseSessionsCreateDto : IDto {
        public string CourseId { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string StartAt { get; set; } = string.Empty;
        public string EndAt { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int Auto { get; set; } = 0;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}