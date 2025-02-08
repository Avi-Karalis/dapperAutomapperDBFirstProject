using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsPagesCreateDto : IDto {
        public ulong CourseId { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public ulong FrontPage { get; set; } = 0;
        public ulong Published { get; set; } = 0;
        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public string PublishAt { get; set; } = string.Empty;
    }
}