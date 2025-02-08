using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_sub_accounts")]
public class CnvSubAccounts : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("workflow_state")] public string WorkflowState { get; set; }
    [Column("parent_account_id")] public ulong ParentAccountId { get; set; }
    [Column("root_account_id")] public ulong RootAccountId { get; set; }
    [Column("uuid")] public string Uuid { get; set; }
    [Column("default_storage_quota_mb")] public ulong DefaultStorageQuotaMb { get; set; }
    [Column("default_user_storage_quota_mb")] public ulong DefaultUserStorageQuotaMb { get; set; }
    [Column("default_group_storage_quota_mb")] public ulong DefaultGroupStorageQuotaMb { get; set; }
    [Column("default_time_zone")] public string DefaultTimeZone { get; set; }
    [Column("sis_account_id")] public string SisAccountId { get; set; }
    [Column("sis_import_id")] public string SisImportId { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("course_template_id")] public string CourseTemplateId { get; set; }

}
