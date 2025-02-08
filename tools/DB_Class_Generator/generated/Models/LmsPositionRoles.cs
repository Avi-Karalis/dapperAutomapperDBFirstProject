using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_position_roles")]
public class LmsPositionRoles : IEntity {
    [Column("position_role_id")] public ulong PositionRoleId { get; set; }
    [Column("position_id")] public ulong PositionId { get; set; }
    [Column("role_id")] public string RoleId { get; set; }
    [Column("status")] public bool Status { get; set; }
    [Column("order")] public bool Order { get; set; }

}
