using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCourseSectionsUpdateDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string StartAt { get; set; } = string.Empty;
        public string EndAt { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string RestrictEnrollmentsToSectionDates { get; set; } = string.Empty;
        public string NonxlistCourseId { get; set; } = string.Empty;
        public string SisSectionId { get; set; } = string.Empty;
        public string SisCourseId { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public string SisImportId { get; set; } = string.Empty;
    }
}