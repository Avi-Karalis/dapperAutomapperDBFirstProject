using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsPositionsCreateDto : IDto {
        public ulong PositionId { get; set; } = 0;
        public string PositionName { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
        public bool Order { get; set; } = false;
    }
}