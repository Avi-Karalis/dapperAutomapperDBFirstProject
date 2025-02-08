using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseDiscussionsCreateDto : IDto {
        public string ParentId { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Created { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
        public ulong 2Id { get; set; }
    }
}