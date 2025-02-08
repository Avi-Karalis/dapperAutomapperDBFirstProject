using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsLovsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string ParentId { get; set; } = string.Empty;
        public string Order { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
        public string Locale { get; set; } = string.Empty;
        public ParentIdDisplayDto? ParentId { get; set; }
    }
}