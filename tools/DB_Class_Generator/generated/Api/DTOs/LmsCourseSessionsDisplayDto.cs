using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseSessionsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string StartAt { get; set; } = string.Empty;
        public string EndAt { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int Auto { get; set; } = 0;
        public StatusDisplayDto? Status { get; set; }
        public CourseIdDisplayDto? CourseId { get; set; }
    }
}