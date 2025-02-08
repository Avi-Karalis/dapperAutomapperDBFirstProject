using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCourseTabsDisplayDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public string Id { get; set; } = string.Empty;
        public string HtmlUrl { get; set; } = string.Empty;
        public string FullUrl { get; set; } = string.Empty;
        public ulong Position { get; set; } = 0;
        public string Visibility { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
}