using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_menus")]
public class LmsMenus : IEntity {
    [Column("menu_id")] public ulong MenuId { get; set; }
    [Column("parent_id")] public ulong ParentId { get; set; }
    [Column("menu_name")] public string MenuName { get; set; }
    [Column("status")] public bool Status { get; set; }
    [Column("order")] public bool Order { get; set; }
    [Column("permission_id")] public string PermissionId { get; set; }

}
