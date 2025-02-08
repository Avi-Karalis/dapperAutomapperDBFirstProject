using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LanguagesCreateDto : IDto {
        public string Code { get; set; } = string.Empty;
        public bool IsContentLanguage { get; set; } = false;
        public bool IsInterfaceLanguage { get; set; } = false;
    }
}