using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LanguagesUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public bool IsContentLanguage { get; set; } = false;
        public bool IsInterfaceLanguage { get; set; } = false;
    }
}