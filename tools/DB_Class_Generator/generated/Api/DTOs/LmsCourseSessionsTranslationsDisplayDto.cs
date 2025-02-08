using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseSessionsTranslationsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string ExtId { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public ExtIdDisplayDto? ExtId { get; set; }
    }
}