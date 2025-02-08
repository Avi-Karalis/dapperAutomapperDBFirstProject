using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseDiscussionsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string ParentId { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Created { get; set; } = string.Empty;
        public AccountIdDisplayDto? AccountId { get; set; }
        public CourseIdDisplayDto? CourseId { get; set; }
        public ParentIdDisplayDto? ParentId { get; set; }
    }
}