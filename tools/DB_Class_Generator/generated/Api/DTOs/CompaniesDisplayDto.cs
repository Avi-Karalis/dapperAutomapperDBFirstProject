using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CompaniesDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public string RootId { get; set; } = string.Empty;
        public string ParentId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Prefix { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
        public string Type { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Vat { get; set; } = string.Empty;
        public string MediaId { get; set; } = string.Empty;
        public string PcMediaId { get; set; } = string.Empty;
        public string DefaultExperienceId { get; set; } = string.Empty;
        public string StripeId { get; set; } = string.Empty;
        public string CardBrand { get; set; } = string.Empty;
        public string CardLastFour { get; set; } = string.Empty;
        public DateTime TrialEndsAt { get; set; } = null;
        public string ContactId { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string BillingType { get; set; } = string.Empty;
        public DateTime DeletedAt { get; set; } = null;
        public DateTime ExpiredAt { get; set; } = null;
        public DateTime ChurnedAt { get; set; } = null;
        public int Status { get; set; } = 0;
        public ContactIdDisplayDto? ContactId { get; set; }
        public PcMediaIdDisplayDto? PcMediaId { get; set; }
        public ParentIdDisplayDto? ParentId { get; set; }
        public RootIdDisplayDto? RootId { get; set; }
    }
}