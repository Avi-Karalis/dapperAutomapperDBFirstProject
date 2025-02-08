using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCompanyContractsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CompanyUserId { get; set; } = string.Empty;
        public string TaxonomyId { get; set; } = string.Empty;
        public DateTime StartAt { get; set; } = null;
        public DateTime EndAt { get; set; } = null;
        public string Status { get; set; } = string.Empty;
        public CompanyUserIdDisplayDto? CompanyUserId { get; set; }
        public TaxonomyIdDisplayDto? TaxonomyId { get; set; }
    }
}