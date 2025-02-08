using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("company_users")]
public class CompanyUsers : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("company_id")] public string CompanyId { get; set; }
    [Column("account_id")] public string AccountId { get; set; }
    [Column("additional_info")] public string AdditionalInfo { get; set; }
    [Column("external_id")] public string ExternalId { get; set; }
    [Column("sync_id")] public string SyncId { get; set; }
    [Column("created_at")] public DateTime CreatedAt { get; set; }
    [Column("updated_at")] public DateTime UpdatedAt { get; set; }
    [Column("deleted_at")] public DateTime DeletedAt { get; set; }
    [Column("experience_id")] public string ExperienceId { get; set; }
    [Column("last_connection")] public DateTime LastConnection { get; set; }
    [Column("learncube_token")] public string LearncubeToken { get; set; }
    [Column("access_start_at")] public DateTime AccessStartAt { get; set; }
    [Column("access_end_at")] public DateTime AccessEndAt { get; set; }
    [Column("access_active_restriction")] public bool AccessActiveRestriction { get; set; }
    [Column("deleted_by")] public string DeletedBy { get; set; }

}
