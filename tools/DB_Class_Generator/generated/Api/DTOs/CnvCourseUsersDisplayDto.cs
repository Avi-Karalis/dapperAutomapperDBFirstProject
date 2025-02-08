using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCourseUsersDisplayDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string SortableName { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string SisUserId { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public string SisImportId { get; set; } = string.Empty;
        public string LoginId { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}