using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsSettingsDisplayDto : IDto {
        public ulong Id { get; set; } = 0;
        public string CacheBuster { get; set; } = string.Empty;
    }
}