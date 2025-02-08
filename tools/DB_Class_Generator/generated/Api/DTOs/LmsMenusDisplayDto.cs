using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsMenusDisplayDto : IDto {
        public ulong MenuId { get; set; } = 0;
        public ulong ParentId { get; set; } = 0;
        public string MenuName { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
        public bool Order { get; set; } = false;
        public string PermissionId { get; set; } = string.Empty;
        public ParentIdDisplayDto? ParentId { get; set; }
        public PermissionIdDisplayDto? PermissionId { get; set; }
    }
}