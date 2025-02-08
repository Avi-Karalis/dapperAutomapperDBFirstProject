using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("courses")]
public class Courses : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("slug")] public string Slug { get; set; }
    [Column("ean")] public string Ean { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("pc_taxonomy_id")] public int PcTaxonomyId { get; set; }
    [Column("likes")] public int Likes { get; set; }
    [Column("status")] public int Status { get; set; }
    [Column("account_id")] public string AccountId { get; set; }
    [Column("course_folder_id")] public string CourseFolderId { get; set; }
    [Column("media_id")] public string MediaId { get; set; }
    [Column("pc_media_id")] public string PcMediaId { get; set; }
    [Column("duration")] public string Duration { get; set; }
    [Column("created_at")] public DateTime CreatedAt { get; set; }
    [Column("updated_at")] public DateTime UpdatedAt { get; set; }
    [Column("deleted_at")] public DateTime DeletedAt { get; set; }
    [Column("weekly_working_duration")] public string WeeklyWorkingDuration { get; set; }
    [Column("default")] public bool Default { get; set; }
    [Column("forced_default")] public bool ForcedDefault { get; set; }
    [Column("schema")] public string Schema { get; set; }
    [Column("template_id")] public string TemplateId { get; set; }
    [Column("parent_version_id")] public string ParentVersionId { get; set; }
    [Column("is_correctionable")] public bool IsCorrectionable { get; set; }
    [Column("realigned_at")] public DateTime RealignedAt { get; set; }
    [Column("company_id")] public string CompanyId { get; set; }
    [Column("language_id")] public string LanguageId { get; set; }
    [Column("state")] public string State { get; set; }
    [Column("external_id")] public string ExternalId { get; set; }
    [Column("automation_id")] public string AutomationId { get; set; }
    [Column("additional_data")] public string AdditionalData { get; set; }
    [Column("last_version")] public DateTime LastVersion { get; set; }
    [Column("version_tag")] public string VersionTag { get; set; }
    [Column("edit_mode")] public string EditMode { get; set; }

}
