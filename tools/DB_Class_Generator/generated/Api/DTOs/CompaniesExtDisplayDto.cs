using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CompaniesExtDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string BaseColor { get; set; } = string.Empty;
        public string HeaderBackground { get; set; } = string.Empty;
        public string PcMediaId { get; set; } = string.Empty;
        public IdDisplayDto? Id { get; set; }
        public PcMediaIdDisplayDto? PcMediaId { get; set; }
    }
}