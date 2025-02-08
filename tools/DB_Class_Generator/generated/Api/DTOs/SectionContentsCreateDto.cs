using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class SectionContentsCreateDto : IDto {
        public string SectionId { get; set; } = string.Empty;
        public string Context { get; set; } = string.Empty;
        public string ContextId { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
        public DateTime DeletedAt { get; set; } = null;
        public int TmpId { get; set; } = 0;
        public string ParentId { get; set; } = string.Empty;
        public bool IsDownloadable { get; set; } = false;
        public string ContentableType { get; set; } = string.Empty;
        public string ContentableId { get; set; } = string.Empty;
        public bool Scorable { get; set; } = false;
        public string Data { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}