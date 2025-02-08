using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_users")]
public class PclmsUsers : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("short_name")] public string ShortName { get; set; }
    [Column("nick_name")] public string NickName { get; set; }
    [Column("email")] public string Email { get; set; }
    [Column("time_zone")] public string TimeZone { get; set; }
    [Column("date_format")] public string DateFormat { get; set; }
    [Column("sis_user_id")] public string SisUserId { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("sis_import_id")] public string SisImportId { get; set; }
    [Column("created_at")] public ulong CreatedAt { get; set; }
    [Column("selected_account_id")] public string SelectedAccountId { get; set; }
    [Column("selected_role_id")] public string SelectedRoleId { get; set; }

}
