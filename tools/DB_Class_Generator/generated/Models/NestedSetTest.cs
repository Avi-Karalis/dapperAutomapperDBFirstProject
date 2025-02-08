using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("nested_set_test")]
public class NestedSetTest : IEntity {
    [Column("id")] public ulong Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("parent_id")] public int ParentId { get; set; }
    [Column("_lft")] public int Lft { get; set; }
    [Column("_rgt")] public int Rgt { get; set; }
    [Column("depth")] public int Depth { get; set; }
    [Column("created_at")] public DateTime CreatedAt { get; set; }
    [Column("updated_at")] public DateTime UpdatedAt { get; set; }

}
