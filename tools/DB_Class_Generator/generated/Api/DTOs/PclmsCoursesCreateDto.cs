using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsCoursesCreateDto : IDto {
        public string AccountId { get; set; } = string.Empty;
        public string CourseCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string FriendlyName { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string CoverMediaId { get; set; } = string.Empty;
        public string CourseColor { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
        public string Lang { get; set; } = string.Empty;
        public ulong StartAt { get; set; } = 0;
        public string StartAtText { get; set; } = string.Empty;
        public ulong EndAt { get; set; } = 0;
        public string EndAtText { get; set; } = string.Empty;
        public string WorkflowState { get; set; } = string.Empty;
        public string SisCourseId { get; set; } = string.Empty;
        public string SisImportId { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public ulong HideFinalGrades { get; set; } = 0;
        public string Uuid { get; set; } = string.Empty;
        public ulong IsPublic { get; set; } = 0;
        public ulong RestrictEnrollmentsToCourseDates { get; set; } = 0;
        public ulong StorageQuotaMb { get; set; } = 0;
        public ulong CreatedAt { get; set; } = 0;
        public string CreatedAtText { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}