using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsTagsI18nDisplayDto : IDto {
        public ulong Id { get; set; } = 0;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}