using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsPositionRolesCreateDto : IDto {
        public ulong PositionRoleId { get; set; } = 0;
        public ulong PositionId { get; set; } = 0;
        public string RoleId { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
        public bool Order { get; set; } = false;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}