using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseTransactionsCreateDto : IDto {
        public string SectionContentId { get; set; } = string.Empty;
        public string CourseSubscriptionId { get; set; } = string.Empty;
        public string ScormBookmark { get; set; } = string.Empty;
        public string ScormProgress { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}