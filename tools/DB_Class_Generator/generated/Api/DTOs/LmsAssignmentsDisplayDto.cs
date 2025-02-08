using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsAssignmentsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string FromId { get; set; } = string.Empty;
        public string ToId { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string CourseSessionId { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
        public DateTime ExpiresAt { get; set; } = null;
        public CourseIdDisplayDto? CourseId { get; set; }
        public CourseSessionIdDisplayDto? CourseSessionId { get; set; }
        public FromIdDisplayDto? FromId { get; set; }
        public ToIdDisplayDto? ToId { get; set; }
    }
}