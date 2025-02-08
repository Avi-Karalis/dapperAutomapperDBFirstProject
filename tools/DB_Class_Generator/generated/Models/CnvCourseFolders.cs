using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_course_folders")]
public class CnvCourseFolders : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("full_name")] public string FullName { get; set; }
    [Column("context_id")] public ulong ContextId { get; set; }
    [Column("context_type")] public string ContextType { get; set; }
    [Column("parent_folder_id")] public string ParentFolderId { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("updated_at")] public string UpdatedAt { get; set; }
    [Column("lock_at")] public string LockAt { get; set; }
    [Column("unlock_at")] public string UnlockAt { get; set; }
    [Column("position")] public string Position { get; set; }
    [Column("locked")] public int Locked { get; set; }
    [Column("folders_url")] public string FoldersUrl { get; set; }
    [Column("files_url")] public string FilesUrl { get; set; }
    [Column("files_count")] public ulong FilesCount { get; set; }
    [Column("folders_count")] public ulong FoldersCount { get; set; }
    [Column("hidden")] public string Hidden { get; set; }
    [Column("locked_for_user")] public int LockedForUser { get; set; }
    [Column("hidden_for_user")] public int HiddenForUser { get; set; }
    [Column("for_submissions")] public int ForSubmissions { get; set; }
    [Column("can_upload")] public int CanUpload { get; set; }

}
