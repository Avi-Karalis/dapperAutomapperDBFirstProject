using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsRolesCreateDto : IDto {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
    }
}