using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsTaxonomiesDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string ParentId { get; set; } = string.Empty;
        public string PcMediaId { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public bool Weight { get; set; } = false;
        public PcMediaIdDisplayDto? PcMediaId { get; set; }
        public ParentIdDisplayDto? ParentId { get; set; }
    }
}