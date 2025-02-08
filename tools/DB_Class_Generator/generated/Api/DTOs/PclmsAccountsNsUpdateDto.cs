using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsAccountsNsUpdateDto : IDto {
        public ulong Id { get; set; } = 0;
        public ulong ParentId { get; set; } = 0;
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
    }
}