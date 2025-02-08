using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsUserRolesDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string AccountUserId { get; set; } = string.Empty;
        public string RoleId { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public AccountUserIdDisplayDto? AccountUserId { get; set; }
        public RoleIdDisplayDto? RoleId { get; set; }
    }
}