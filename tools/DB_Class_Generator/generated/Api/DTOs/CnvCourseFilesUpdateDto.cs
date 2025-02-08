using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCourseFilesUpdateDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong Id { get; set; } = 0;
        public string Uuid { get; set; } = string.Empty;
        public ulong FolderId { get; set; } = 0;
        public string DisplayName { get; set; } = string.Empty;
        public string Filename { get; set; } = string.Empty;
        public string UploadStatus { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public ulong Size { get; set; } = 0;
        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public string UnlockAt { get; set; } = string.Empty;
        public int Locked { get; set; } = 0;
        public int Hidden { get; set; } = 0;
        public string LockAt { get; set; } = string.Empty;
        public int HiddenForUser { get; set; } = 0;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string ModifiedAt { get; set; } = string.Empty;
        public string MimeClass { get; set; } = string.Empty;
        public string MediaEntryId { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public int LockedForUser { get; set; } = 0;
        public string VisibilityLevel { get; set; } = string.Empty;
    }
}