using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_course_files")]
public class CnvCourseFiles : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("uuid")] public string Uuid { get; set; }
    [Column("folder_id")] public ulong FolderId { get; set; }
    [Column("display_name")] public string DisplayName { get; set; }
    [Column("filename")] public string Filename { get; set; }
    [Column("upload_status")] public string UploadStatus { get; set; }
    [Column("content_type")] public string ContentType { get; set; }
    [Column("url")] public string Url { get; set; }
    [Column("size")] public ulong Size { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("updated_at")] public string UpdatedAt { get; set; }
    [Column("unlock_at")] public string UnlockAt { get; set; }
    [Column("locked")] public int Locked { get; set; }
    [Column("hidden")] public int Hidden { get; set; }
    [Column("lock_at")] public string LockAt { get; set; }
    [Column("hidden_for_user")] public int HiddenForUser { get; set; }
    [Column("thumbnail_url")] public string ThumbnailUrl { get; set; }
    [Column("modified_at")] public string ModifiedAt { get; set; }
    [Column("mime_class")] public string MimeClass { get; set; }
    [Column("media_entry_id")] public string MediaEntryId { get; set; }
    [Column("category")] public string Category { get; set; }
    [Column("locked_for_user")] public int LockedForUser { get; set; }
    [Column("visibility_level")] public string VisibilityLevel { get; set; }

}
