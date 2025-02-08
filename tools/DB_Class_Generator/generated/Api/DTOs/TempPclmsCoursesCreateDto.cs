using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class TempPclmsCoursesCreateDto : IDto {
        public string Account { get; set; } = string.Empty;
        public string CourseCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string FriendlyName { get; set; } = string.Empty;
        public string CourseColor { get; set; } = string.Empty;
        public ulong StartAt { get; set; } = 0;
        public ulong EndAt { get; set; } = 0;
        public string TimeZone { get; set; } = string.Empty;
        public string WorkflowState { get; set; } = string.Empty;
        public int IsPublic { get; set; } = 0;
        public int RestrictEnrollmentsToCourseDates { get; set; } = 0;
        public string IntegrationId { get; set; } = string.Empty;
        public int HideFinalGrades { get; set; } = 0;
        public string Uuid { get; set; } = string.Empty;
        public ulong CreatedAt { get; set; } = 0;
    }
}