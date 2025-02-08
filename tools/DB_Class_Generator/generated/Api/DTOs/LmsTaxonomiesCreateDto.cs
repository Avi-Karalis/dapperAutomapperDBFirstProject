using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsTaxonomiesCreateDto : IDto {
        public string ParentId { get; set; } = string.Empty;
        public string PcMediaId { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public bool Weight { get; set; } = false;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}