using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCourseModuleItemsDisplayDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong Id { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public ulong Position { get; set; } = 0;
        public ulong Indent { get; set; } = 0;
        public int QuizLti { get; set; } = 0;
        public string Type { get; set; } = string.Empty;
        public ulong ModuleId { get; set; } = 0;
        public string HtmlUrl { get; set; } = string.Empty;
        public string PageUrl { get; set; } = string.Empty;
        public string PublishAt { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public int Published { get; set; } = 0;
        public int Unpublishable { get; set; } = 0;
    }
}