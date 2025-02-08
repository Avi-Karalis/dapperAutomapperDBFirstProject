using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MediaUploadsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string OriginBasename { get; set; } = string.Empty;
        public string OriginExtension { get; set; } = string.Empty;
        public string StorageDirectory { get; set; } = string.Empty;
        public string StorageBasename { get; set; } = string.Empty;
        public string StorageExtension { get; set; } = string.Empty;
        public string OriginalUrl { get; set; } = string.Empty;
        public string ImsVersion { get; set; } = string.Empty;
        public string ScormVersion { get; set; } = string.Empty;
        public string ScormResourseHref { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
        public string Attempts { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public string CompanyUsersId { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
        public DateTime DeletedAt { get; set; } = null;
        public bool Gallery { get; set; } = false;
        public string PcThumbId { get; set; } = string.Empty;
        public string Base64 { get; set; } = string.Empty;
        public AccountIdDisplayDto? AccountId { get; set; }
        public CompanyUsersIdDisplayDto? CompanyUsersId { get; set; }
        public PcThumbIdDisplayDto? PcThumbId { get; set; }
    }
}