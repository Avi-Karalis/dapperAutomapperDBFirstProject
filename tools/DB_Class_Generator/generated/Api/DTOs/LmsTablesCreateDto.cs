using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsTablesCreateDto : IDto {
        public string Name { get; set; } = string.Empty;
    }
}