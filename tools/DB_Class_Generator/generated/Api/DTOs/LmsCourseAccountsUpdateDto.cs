using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseAccountsUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}