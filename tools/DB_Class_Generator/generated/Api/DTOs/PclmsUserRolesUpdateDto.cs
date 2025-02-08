using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsUserRolesUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string AccountUserId { get; set; } = string.Empty;
        public string RoleId { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}