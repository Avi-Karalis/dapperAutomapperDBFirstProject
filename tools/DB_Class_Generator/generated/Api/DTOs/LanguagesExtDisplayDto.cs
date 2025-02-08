using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LanguagesExtDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Ico { get; set; } = string.Empty;
        public IdDisplayDto? Id { get; set; }
    }
}