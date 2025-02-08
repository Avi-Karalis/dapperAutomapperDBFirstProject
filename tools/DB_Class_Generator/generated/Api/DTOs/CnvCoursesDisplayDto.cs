using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCoursesDisplayDto : IDto {
        public int RowId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public ulong AccountId { get; set; } = 0;
        public string Uuid { get; set; } = string.Empty;
        public string StartAt { get; set; } = string.Empty;
        public string GradingStandardId { get; set; } = string.Empty;
        public int IsPublic { get; set; } = 0;
        public string CreatedAt { get; set; } = string.Empty;
        public string CourseCode { get; set; } = string.Empty;
        public string DefaultView { get; set; } = string.Empty;
        public ulong RootAccountId { get; set; } = 0;
        public ulong EnrollmentTermId { get; set; } = 0;
        public string License { get; set; } = string.Empty;
        public string GradePassbackSetting { get; set; } = string.Empty;
        public string EndAt { get; set; } = string.Empty;
        public int PublicSyllabus { get; set; } = 0;
        public int PublicSyllabusToAuth { get; set; } = 0;
        public ulong StorageQuotaMb { get; set; } = 0;
        public int IsPublicToAuthUsers { get; set; } = 0;
        public int HomeroomCourse { get; set; } = 0;
        public string CourseColor { get; set; } = string.Empty;
        public string FriendlyName { get; set; } = string.Empty;
        public int ApplyAssignmentGroupWeights { get; set; } = 0;
        public string Calendar_Ics { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
        public int Blueprint { get; set; } = 0;
        public int Template { get; set; } = 0;
        public string SisCourseId { get; set; } = string.Empty;
        public string SisImportId { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public int HideFinalGrades { get; set; } = 0;
        public string WorkflowState { get; set; } = string.Empty;
        public int RestrictEnrollmentsToCourseDates { get; set; } = 0;
    }
}