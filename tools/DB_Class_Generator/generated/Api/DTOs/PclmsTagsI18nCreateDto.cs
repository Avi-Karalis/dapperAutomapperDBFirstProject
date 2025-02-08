using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsTagsI18nCreateDto : IDto {
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}