using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MigrationsCreateDto : IDto {
        public string Migration { get; set; } = string.Empty;
        public int Batch { get; set; } = 0;
    }
}