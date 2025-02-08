using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsAssignmentsCreateDto : IDto {
        public string FromId { get; set; } = string.Empty;
        public string ToId { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string CourseSessionId { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
        public DateTime ExpiresAt { get; set; } = null;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
        public ulong 2Id { get; set; }
        public ulong 3Id { get; set; }
    }
}