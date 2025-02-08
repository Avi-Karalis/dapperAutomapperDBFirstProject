using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseSessionAccountTransactionsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseSessionAccountId { get; set; } = string.Empty;
        public string SectionContentId { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
        public CourseSessionAccountIdDisplayDto? CourseSessionAccountId { get; set; }
        public SectionContentIdDisplayDto? SectionContentId { get; set; }
    }
}