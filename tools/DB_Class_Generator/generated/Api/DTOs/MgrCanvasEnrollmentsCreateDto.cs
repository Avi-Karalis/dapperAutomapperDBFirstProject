using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MgrCanvasEnrollmentsCreateDto : IDto {
        public int RowId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong UserId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public string Type { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public string AssociatedUserId { get; set; } = string.Empty;
        public string StartAt { get; set; } = string.Empty;
        public string EndAt { get; set; } = string.Empty;
        public ulong CourseSectionId { get; set; } = 0;
        public ulong RootAccountId { get; set; } = 0;
        public int LimitPrivilegesToCourseSection { get; set; } = 0;
        public string EnrollmentState { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public ulong RoleId { get; set; } = 0;
        public string LastActivityAt { get; set; } = string.Empty;
        public string LastAttendedAt { get; set; } = string.Empty;
        public ulong TotalActivityTime { get; set; } = 0;
        public string SisImportId { get; set; } = string.Empty;
        public string SisAccountId { get; set; } = string.Empty;
        public string SisCourseId { get; set; } = string.Empty;
        public string CourseIntegrationId { get; set; } = string.Empty;
        public string SisSectionId { get; set; } = string.Empty;
        public string SectionIntegrationId { get; set; } = string.Empty;
        public string SisUserId { get; set; } = string.Empty;
        public string HtmlUrl { get; set; } = string.Empty;
        public ulong User_Id { get; set; } = 0;
        public string User_Name { get; set; } = string.Empty;
        public string User_CreatedAt { get; set; } = string.Empty;
        public string User_SortableName { get; set; } = string.Empty;
        public string User_ShortName { get; set; } = string.Empty;
        public string User_SisUserId { get; set; } = string.Empty;
        public string User_IntegrationId { get; set; } = string.Empty;
        public string User_SisImportId { get; set; } = string.Empty;
        public string User_LoginId { get; set; } = string.Empty;
    }
}