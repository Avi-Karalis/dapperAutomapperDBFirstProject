using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsIntegrationUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string Entity { get; set; } = string.Empty;
        public int ExternalId { get; set; } = 0;
        public int EntityId { get; set; } = 0;
        public int Status { get; set; } = 0;
    }
}