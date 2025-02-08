using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsTranslationsCreateDto : IDto {
        public string TableId { get; set; } = string.Empty;
        public string TableName { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}