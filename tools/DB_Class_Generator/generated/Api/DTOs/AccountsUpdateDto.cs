using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class AccountsUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string SelectedCompanyId { get; set; } = string.Empty;
        public string SisUserId { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public string Uuid { get; set; } = string.Empty;
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Headline { get; set; } = string.Empty;
        public string Biography { get; set; } = string.Empty;
        public string MediaId { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string BackgroundImageId { get; set; } = string.Empty;
        public string DateFormat { get; set; } = string.Empty;
        public string Timezone { get; set; } = string.Empty;
        public string UploadFolderId { get; set; } = string.Empty;
        public bool LegalMentions { get; set; } = false;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
        public DateTime LastConnection { get; set; } = null;
        public DateTime DeletedAt { get; set; } = null;
        public bool Onboarding { get; set; } = false;
        public string ProductTour { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public string InvitationId { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string LanguageId { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string PcMeta { get; set; } = string.Empty;
        public string Roles { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}