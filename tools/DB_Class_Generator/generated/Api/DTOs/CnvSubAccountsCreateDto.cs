using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvSubAccountsCreateDto : IDto {
        public int RowId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string WorkflowState { get; set; } = string.Empty;
        public ulong ParentAccountId { get; set; } = 0;
        public ulong RootAccountId { get; set; } = 0;
        public string Uuid { get; set; } = string.Empty;
        public ulong DefaultStorageQuotaMb { get; set; } = 0;
        public ulong DefaultUserStorageQuotaMb { get; set; } = 0;
        public ulong DefaultGroupStorageQuotaMb { get; set; } = 0;
        public string DefaultTimeZone { get; set; } = string.Empty;
        public string SisAccountId { get; set; } = string.Empty;
        public string SisImportId { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public string CourseTemplateId { get; set; } = string.Empty;
    }
}