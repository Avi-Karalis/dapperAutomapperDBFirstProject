using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsTranslationsUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string TableId { get; set; } = string.Empty;
        public string TableName { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}