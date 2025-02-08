using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsTranslationLanguagesDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string LmsTranslationId { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public LmsTranslationIdDisplayDto? LmsTranslationId { get; set; }
    }
}