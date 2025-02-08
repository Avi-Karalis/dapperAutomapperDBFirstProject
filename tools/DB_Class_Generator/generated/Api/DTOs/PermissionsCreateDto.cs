using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PermissionsCreateDto : IDto {
        public string Name { get; set; } = string.Empty;
        public string GuardName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
    }
}