using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MigrationsUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Migration { get; set; } = string.Empty;
        public int Batch { get; set; } = 0;
    }
}