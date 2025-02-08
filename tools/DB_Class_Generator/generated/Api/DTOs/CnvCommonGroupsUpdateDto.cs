using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCommonGroupsUpdateDto : IDto {
        public int RowId { get; set; } = 0;
        public string AccountId { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}