using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsIntegrationDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}