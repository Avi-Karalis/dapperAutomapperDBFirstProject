using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CompanyUsersDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CompanyId { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public string AdditionalInfo { get; set; } = string.Empty;
        public string ExternalId { get; set; } = string.Empty;
        public string SyncId { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
        public DateTime DeletedAt { get; set; } = null;
        public string ExperienceId { get; set; } = string.Empty;
        public DateTime LastConnection { get; set; } = null;
        public string LearncubeToken { get; set; } = string.Empty;
        public DateTime AccessStartAt { get; set; } = null;
        public DateTime AccessEndAt { get; set; } = null;
        public bool AccessActiveRestriction { get; set; } = false;
        public string DeletedBy { get; set; } = string.Empty;
        public DeletedByDisplayDto? DeletedBy { get; set; }
        public CompanyIdDisplayDto? CompanyId { get; set; }
        public AccountIdDisplayDto? AccountId { get; set; }
    }
}