using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsFilesUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string FolderId { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string Filename { get; set; } = string.Empty;
        public string StoragePath { get; set; } = string.Empty;
        public string UploadStatus { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public string MimeType { get; set; } = string.Empty;
        public ulong Size { get; set; } = 0;
        public int Status { get; set; } = 0;
        public string ThumbnailBase64 { get; set; } = string.Empty;
        public string ScormVersion { get; set; } = string.Empty;
        public string ScormResourseHref { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}