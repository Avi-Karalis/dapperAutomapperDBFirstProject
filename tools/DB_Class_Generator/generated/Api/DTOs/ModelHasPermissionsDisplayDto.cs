using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class ModelHasPermissionsDisplayDto : IDto {
        public string PermissionId { get; set; } = string.Empty;
        public string ModelType { get; set; } = string.Empty;
        public string ModelId { get; set; } = string.Empty;
        public PermissionIdDisplayDto? PermissionId { get; set; }
    }
}