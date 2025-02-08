using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LanguagesI18nDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IdDisplayDto? Id { get; set; }
    }
}