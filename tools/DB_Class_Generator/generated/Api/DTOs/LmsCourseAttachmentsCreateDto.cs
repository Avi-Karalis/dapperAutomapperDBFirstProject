using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseAttachmentsCreateDto : IDto {
        public string CourseId { get; set; } = string.Empty;
        public string MediaId { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}