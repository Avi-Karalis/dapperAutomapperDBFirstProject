using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsTagsUpdateDto : IDto {
        public ulong Id { get; set; } = 0;
        public ulong ParentId { get; set; } = 0;
        public ulong PcMediaId { get; set; } = 0;
        public string Color { get; set; } = string.Empty;
        public bool Weight { get; set; } = false;
    }
}