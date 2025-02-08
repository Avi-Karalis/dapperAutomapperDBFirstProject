using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cache")]
public class Cache : IEntity {
    [Column("key")] public string Key { get; set; }
    [Column("value")] public string Value { get; set; }
    [Column("expiration")] public int Expiration { get; set; }

}
