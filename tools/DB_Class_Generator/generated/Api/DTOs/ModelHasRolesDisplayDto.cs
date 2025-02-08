using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class ModelHasRolesDisplayDto : IDto {
        public string RoleId { get; set; } = string.Empty;
        public string ModelType { get; set; } = string.Empty;
        public string ModelId { get; set; } = string.Empty;
        public RoleIdDisplayDto? RoleId { get; set; }
    }
}