using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseAttachmentsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string MediaId { get; set; } = string.Empty;
        public CourseIdDisplayDto? CourseId { get; set; }
        public MediaIdDisplayDto? MediaId { get; set; }
    }
}