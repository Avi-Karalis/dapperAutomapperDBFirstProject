using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MigrationsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}