using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class SectionContentTranslationsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string SectionContentId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public SectionContentIdDisplayDto? SectionContentId { get; set; }
    }
}