using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CompaniesExtCreateDto : IDto {
        public string BaseColor { get; set; } = string.Empty;
        public string HeaderBackground { get; set; } = string.Empty;
        public string PcMediaId { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}