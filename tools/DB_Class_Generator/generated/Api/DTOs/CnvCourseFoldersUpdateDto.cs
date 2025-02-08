using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCourseFoldersUpdateDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public ulong ContextId { get; set; } = 0;
        public string ContextType { get; set; } = string.Empty;
        public string ParentFolderId { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public string LockAt { get; set; } = string.Empty;
        public string UnlockAt { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public int Locked { get; set; } = 0;
        public string FoldersUrl { get; set; } = string.Empty;
        public string FilesUrl { get; set; } = string.Empty;
        public ulong FilesCount { get; set; } = 0;
        public ulong FoldersCount { get; set; } = 0;
        public string Hidden { get; set; } = string.Empty;
        public int LockedForUser { get; set; } = 0;
        public int HiddenForUser { get; set; } = 0;
        public int ForSubmissions { get; set; } = 0;
        public int CanUpload { get; set; } = 0;
    }
}