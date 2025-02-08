using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_roles")]
public class PclmsRoles : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("status")] public int Status { get; set; }

}
