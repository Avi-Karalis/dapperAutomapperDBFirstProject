using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class RoleHasPermissionsUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string PermissionId { get; set; } = string.Empty;
        public string RoleId { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}