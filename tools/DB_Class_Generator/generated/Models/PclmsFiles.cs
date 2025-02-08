using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_files")]
public class PclmsFiles : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("folder_id")] public string FolderId { get; set; }
    [Column("display_name")] public string DisplayName { get; set; }
    [Column("filename")] public string Filename { get; set; }
    [Column("storage_path")] public string StoragePath { get; set; }
    [Column("upload_status")] public string UploadStatus { get; set; }
    [Column("content_type")] public string ContentType { get; set; }
    [Column("mime_type")] public string MimeType { get; set; }
    [Column("size")] public ulong Size { get; set; }
    [Column("status")] public int Status { get; set; }
    [Column("thumbnail_base64")] public string ThumbnailBase64 { get; set; }
    [Column("scorm_version")] public string ScormVersion { get; set; }
    [Column("scorm_resourse_href")] public string ScormResourseHref { get; set; }

}
