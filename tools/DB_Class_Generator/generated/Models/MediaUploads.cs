using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("media_uploads")]
public class MediaUploads : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("size")] public string Size { get; set; }
    [Column("origin_basename")] public string OriginBasename { get; set; }
    [Column("origin_extension")] public string OriginExtension { get; set; }
    [Column("storage_directory")] public string StorageDirectory { get; set; }
    [Column("storage_basename")] public string StorageBasename { get; set; }
    [Column("storage_extension")] public string StorageExtension { get; set; }
    [Column("original_url")] public string OriginalUrl { get; set; }
    [Column("ims_version")] public string ImsVersion { get; set; }
    [Column("scorm_version")] public string ScormVersion { get; set; }
    [Column("scorm_resourse_href")] public string ScormResourseHref { get; set; }
    [Column("status")] public bool Status { get; set; }
    [Column("attempts")] public string Attempts { get; set; }
    [Column("account_id")] public string AccountId { get; set; }
    [Column("company_users_id")] public string CompanyUsersId { get; set; }
    [Column("created_at")] public DateTime CreatedAt { get; set; }
    [Column("updated_at")] public DateTime UpdatedAt { get; set; }
    [Column("deleted_at")] public DateTime DeletedAt { get; set; }
    [Column("gallery")] public bool Gallery { get; set; }
    [Column("pc_thumb_id")] public string PcThumbId { get; set; }
    [Column("base64")] public string Base64 { get; set; }

}
