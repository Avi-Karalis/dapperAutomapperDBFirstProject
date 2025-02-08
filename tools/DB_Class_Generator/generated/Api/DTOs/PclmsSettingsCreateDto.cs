using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsSettingsCreateDto : IDto {
        public string CacheBuster { get; set; } = string.Empty;
    }
}