using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_tags")]
public class PclmsTags : IEntity {
    [Column("id")] public ulong Id { get; set; }
    [Column("parent_id")] public ulong ParentId { get; set; }
    [Column("pc_media_id")] public ulong PcMediaId { get; set; }
    [Column("color")] public string Color { get; set; }
    [Column("weight")] public bool Weight { get; set; }

}
