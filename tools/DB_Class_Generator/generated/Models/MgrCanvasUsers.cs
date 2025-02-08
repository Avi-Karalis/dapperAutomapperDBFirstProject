using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("mgr_canvas_users")]
public class MgrCanvasUsers : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("sortable_name")] public string SortableName { get; set; }
    [Column("short_name")] public string ShortName { get; set; }
    [Column("sis_user_id")] public string SisUserId { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("sis_import_id")] public string SisImportId { get; set; }
    [Column("login_id")] public string LoginId { get; set; }
    [Column("last_name")] public string LastName { get; set; }
    [Column("first_name")] public string FirstName { get; set; }
    [Column("email")] public string Email { get; set; }
    [Column("locale")] public string Locale { get; set; }
    [Column("permissions__can_update_name")] public int Permissions_CanUpdateName { get; set; }
    [Column("permissions__can_update_avatar")] public int Permissions_CanUpdateAvatar { get; set; }
    [Column("permissions__limit_parent_app_web_access")] public int Permissions_LimitParentAppWebAccess { get; set; }

}
