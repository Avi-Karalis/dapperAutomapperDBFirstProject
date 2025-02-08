using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsRolePermissionsUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string PermissionId { get; set; } = string.Empty;
        public string RoleId { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
    }
}