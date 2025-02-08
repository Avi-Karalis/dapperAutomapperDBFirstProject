using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MgrCanvasCoursesBckDisplayDto : IDto {
        public string MyRowId { get; set; } = string.Empty;
        public int RowId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public int AccountId { get; set; } = 0;
        public string Uuid { get; set; } = string.Empty;
        public string StartAt { get; set; } = string.Empty;
        public string GradingStandardId { get; set; } = string.Empty;
        public string IsPublic { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string CourseCode { get; set; } = string.Empty;
        public string DefaultView { get; set; } = string.Empty;
        public int RootAccountId { get; set; } = 0;
        public int EnrollmentTermId { get; set; } = 0;
        public string License { get; set; } = string.Empty;
        public string GradePassbackSetting { get; set; } = string.Empty;
        public string EndAt { get; set; } = string.Empty;
        public string PublicSyllabus { get; set; } = string.Empty;
        public string PublicSyllabusToAuth { get; set; } = string.Empty;
        public int StorageQuotaMb { get; set; } = 0;
        public string IsPublicToAuthUsers { get; set; } = string.Empty;
        public string HomeroomCourse { get; set; } = string.Empty;
        public string CourseColor { get; set; } = string.Empty;
        public string FriendlyName { get; set; } = string.Empty;
        public string ApplyAssignmentGroupWeights { get; set; } = string.Empty;
        public string Calendarics { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
        public string Blueprint { get; set; } = string.Empty;
        public string Template { get; set; } = string.Empty;
        public string SisCourseId { get; set; } = string.Empty;
        public string SisImportId { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public string HideFinalGrades { get; set; } = string.Empty;
        public string WorkflowState { get; set; } = string.Empty;
        public string RestrictEnrollmentsToCourseDates { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string BlueprintRestrictions { get; set; } = string.Empty;
        public string BlueprintRestrictionsByObjectType { get; set; } = string.Empty;
        public string CourseFormat { get; set; } = string.Empty;
    }
}