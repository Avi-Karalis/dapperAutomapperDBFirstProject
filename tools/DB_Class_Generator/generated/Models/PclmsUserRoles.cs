using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_user_roles")]
public class PclmsUserRoles : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("account_user_id")] public string AccountUserId { get; set; }
    [Column("role_id")] public string RoleId { get; set; }
    [Column("status")] public string Status { get; set; }

}
