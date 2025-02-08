using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseSessionAccountTransactionsCreateDto : IDto {
        public string CourseSessionAccountId { get; set; } = string.Empty;
        public string SectionContentId { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}