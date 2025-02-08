using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsTranslationLanguagesUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string LmsTranslationId { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}