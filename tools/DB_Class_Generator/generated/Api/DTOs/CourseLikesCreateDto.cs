using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CourseLikesCreateDto : IDto {
        public string CourseId { get; set; } = string.Empty;
        public string CompanyUserId { get; set; } = string.Empty;
        public DateTime DeletedAt { get; set; } = null;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}