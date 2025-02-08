using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class RolesDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string GuardName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
    }
}