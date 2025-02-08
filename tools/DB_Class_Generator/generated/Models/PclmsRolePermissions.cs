using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_role_permissions")]
public class PclmsRolePermissions : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("permission_id")] public string PermissionId { get; set; }
    [Column("role_id")] public string RoleId { get; set; }
    [Column("status")] public int Status { get; set; }

}
