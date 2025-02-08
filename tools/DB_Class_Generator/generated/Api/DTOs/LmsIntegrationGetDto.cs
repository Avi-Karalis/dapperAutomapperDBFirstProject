using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsIntegrationGetDto : IDto {
        public ulong Id { get; set; }
    }
}