using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsCourseSectionsCreateDto : IDto {
        public ulong CourseId { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public ulong StartAt { get; set; } = 0;
        public ulong EndAt { get; set; } = 0;
        public int Published { get; set; } = 0;
        public int RestrictEnrollmentsToSectionDates { get; set; } = 0;
    }
}