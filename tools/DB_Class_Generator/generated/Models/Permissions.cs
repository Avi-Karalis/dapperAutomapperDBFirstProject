using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("permissions")]
public class Permissions : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("guard_name")] public string GuardName { get; set; }
    [Column("created_at")] public DateTime CreatedAt { get; set; }
    [Column("updated_at")] public DateTime UpdatedAt { get; set; }

}
