using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsRolePermissionsCreateDto : IDto {
        public string PermissionId { get; set; } = string.Empty;
        public string RoleId { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
    }
}