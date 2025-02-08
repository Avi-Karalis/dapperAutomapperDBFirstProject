using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsMenusUpdateDto : IDto {
        public ulong MenuId { get; set; } = 0;
        public ulong ParentId { get; set; } = 0;
        public string MenuName { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
        public bool Order { get; set; } = false;
        public string PermissionId { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}