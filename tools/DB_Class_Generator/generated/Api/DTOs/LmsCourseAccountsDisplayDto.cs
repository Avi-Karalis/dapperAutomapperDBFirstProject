using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseAccountsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
        public AccountIdDisplayDto? AccountId { get; set; }
        public CourseIdDisplayDto? CourseId { get; set; }
    }
}