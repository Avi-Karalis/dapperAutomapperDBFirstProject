using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsCourseUsersDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string AccountUserId { get; set; } = string.Empty;
        public string StartAt { get; set; } = string.Empty;
        public string EndAt { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public AccountUserIdDisplayDto? AccountUserId { get; set; }
        public CourseIdDisplayDto? CourseId { get; set; }
    }
}