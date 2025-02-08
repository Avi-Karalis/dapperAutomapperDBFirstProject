using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class SectionsUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string Context { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
        public string MediaId { get; set; } = string.Empty;
        public string ParentId { get; set; } = string.Empty;
        public DateTime DeletedAt { get; set; } = null;
        public bool TrainerOnly { get; set; } = false;
        public ulong StartAt { get; set; } = 0;
        public ulong EndAt { get; set; } = 0;
        public string Type { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}