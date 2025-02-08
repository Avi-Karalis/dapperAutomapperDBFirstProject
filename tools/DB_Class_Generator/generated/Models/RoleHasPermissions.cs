using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("role_has_permissions")]
public class RoleHasPermissions : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("permission_id")] public string PermissionId { get; set; }
    [Column("role_id")] public string RoleId { get; set; }

}
