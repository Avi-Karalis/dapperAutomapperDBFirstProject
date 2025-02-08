using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsCourseUsersUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string AccountUserId { get; set; } = string.Empty;
        public string StartAt { get; set; } = string.Empty;
        public string EndAt { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}