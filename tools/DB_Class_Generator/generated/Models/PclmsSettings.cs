using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_settings")]
public class PclmsSettings : IEntity {
    [Column("id")] public ulong Id { get; set; }
    [Column("cache_buster")] public string CacheBuster { get; set; }

}
