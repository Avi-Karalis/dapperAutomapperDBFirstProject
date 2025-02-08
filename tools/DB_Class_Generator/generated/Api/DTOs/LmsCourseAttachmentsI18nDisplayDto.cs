using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseAttachmentsI18nDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public IdDisplayDto? Id { get; set; }
    }
}