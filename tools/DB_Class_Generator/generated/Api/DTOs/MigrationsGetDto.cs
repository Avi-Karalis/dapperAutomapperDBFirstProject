using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MigrationsGetDto : IDto {
        public ulong Id { get; set; }
    }
}