using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_permissions")]
public class PclmsPermissions : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("status")] public int Status { get; set; }

}
