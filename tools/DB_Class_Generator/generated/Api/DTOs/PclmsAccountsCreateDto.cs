using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsAccountsCreateDto : IDto {
        public string ParentId { get; set; } = string.Empty;
        public ulong Lft { get; set; } = 0;
        public ulong Rgt { get; set; } = 0;
        public ulong Depth { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string WorkflowState { get; set; } = string.Empty;
        public ulong RootAccountId { get; set; } = 0;
        public string Uuid { get; set; } = string.Empty;
        public ulong DefaultStorageQuotaMb { get; set; } = 0;
        public ulong DefaultUserStorageQuotaMb { get; set; } = 0;
        public ulong DefaultGroupStorageQuotaMb { get; set; } = 0;
        public string DefaultTimeZone { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
    }
}