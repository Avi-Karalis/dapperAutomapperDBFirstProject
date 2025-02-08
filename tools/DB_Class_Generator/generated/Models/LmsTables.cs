using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_tables")]
public class LmsTables : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("name")] public string Name { get; set; }

}
