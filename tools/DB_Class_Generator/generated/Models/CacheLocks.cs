using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cache_locks")]
public class CacheLocks : IEntity {
    [Column("key")] public string Key { get; set; }
    [Column("owner")] public string Owner { get; set; }
    [Column("expiration")] public int Expiration { get; set; }

}
