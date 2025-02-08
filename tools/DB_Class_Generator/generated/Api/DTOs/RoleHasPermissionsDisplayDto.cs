using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class RoleHasPermissionsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string PermissionId { get; set; } = string.Empty;
        public string RoleId { get; set; } = string.Empty;
        public PermissionIdDisplayDto? PermissionId { get; set; }
        public RoleIdDisplayDto? RoleId { get; set; }
    }
}