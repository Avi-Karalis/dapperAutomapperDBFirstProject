using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("migrations")]
public class Migrations : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("migration")] public string Migration { get; set; }
    [Column("batch")] public int Batch { get; set; }

}
