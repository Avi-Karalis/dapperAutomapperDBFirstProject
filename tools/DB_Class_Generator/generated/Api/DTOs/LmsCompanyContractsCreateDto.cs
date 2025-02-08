using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCompanyContractsCreateDto : IDto {
        public string CompanyUserId { get; set; } = string.Empty;
        public string TaxonomyId { get; set; } = string.Empty;
        public DateTime StartAt { get; set; } = null;
        public DateTime EndAt { get; set; } = null;
        public string Status { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}