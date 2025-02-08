using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CoursesDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Ean { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int PcTaxonomyId { get; set; } = 0;
        public int Likes { get; set; } = 0;
        public int Status { get; set; } = 0;
        public string AccountId { get; set; } = string.Empty;
        public string CourseFolderId { get; set; } = string.Empty;
        public string MediaId { get; set; } = string.Empty;
        public string PcMediaId { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
        public DateTime DeletedAt { get; set; } = null;
        public string WeeklyWorkingDuration { get; set; } = string.Empty;
        public bool Default { get; set; } = false;
        public bool ForcedDefault { get; set; } = false;
        public string Schema { get; set; } = string.Empty;
        public string TemplateId { get; set; } = string.Empty;
        public string ParentVersionId { get; set; } = string.Empty;
        public bool IsCorrectionable { get; set; } = false;
        public DateTime RealignedAt { get; set; } = null;
        public string CompanyId { get; set; } = string.Empty;
        public string LanguageId { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ExternalId { get; set; } = string.Empty;
        public string AutomationId { get; set; } = string.Empty;
        public string AdditionalData { get; set; } = string.Empty;
        public DateTime LastVersion { get; set; } = null;
        public string VersionTag { get; set; } = string.Empty;
        public string EditMode { get; set; } = string.Empty;
        public AccountIdDisplayDto? AccountId { get; set; }
        public CompanyIdDisplayDto? CompanyId { get; set; }
        public LanguageIdDisplayDto? LanguageId { get; set; }
        public PcMediaIdDisplayDto? PcMediaId { get; set; }
        public TemplateIdDisplayDto? TemplateId { get; set; }
        public ParentVersionIdDisplayDto? ParentVersionId { get; set; }
    }
}