using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CourseLikesDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string CompanyUserId { get; set; } = string.Empty;
        public DateTime DeletedAt { get; set; } = null;
        public CompanyUserIdDisplayDto? CompanyUserId { get; set; }
        public CourseIdDisplayDto? CourseId { get; set; }
    }
}