using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_accounts")]
public class PclmsAccounts : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("parent_id")] public string ParentId { get; set; }
    [Column("_lft")] public ulong Lft { get; set; }
    [Column("_rgt")] public ulong Rgt { get; set; }
    [Column("depth")] public ulong Depth { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("workflow_state")] public string WorkflowState { get; set; }
    [Column("root_account_id")] public ulong RootAccountId { get; set; }
    [Column("uuid")] public string Uuid { get; set; }
    [Column("default_storage_quota_mb")] public ulong DefaultStorageQuotaMb { get; set; }
    [Column("default_user_storage_quota_mb")] public ulong DefaultUserStorageQuotaMb { get; set; }
    [Column("default_group_storage_quota_mb")] public ulong DefaultGroupStorageQuotaMb { get; set; }
    [Column("default_time_zone")] public string DefaultTimeZone { get; set; }
    [Column("status")] public int Status { get; set; }

}
