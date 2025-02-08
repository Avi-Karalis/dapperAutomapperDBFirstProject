using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseSessionAccountsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseSessionId { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
        public int CourseProgress { get; set; } = 0;
        public string IsTeacher { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public AccountIdDisplayDto? AccountId { get; set; }
        public CourseSessionIdDisplayDto? CourseSessionId { get; set; }
    }
}