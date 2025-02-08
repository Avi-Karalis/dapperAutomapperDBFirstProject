using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseAssetsCreateDto : IDto {
        public string CourseId { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}