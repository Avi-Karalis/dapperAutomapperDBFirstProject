using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class SectionTranslationsUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string SectionId { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}