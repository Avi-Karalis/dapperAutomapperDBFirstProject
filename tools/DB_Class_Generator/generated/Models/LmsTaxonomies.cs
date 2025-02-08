using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_taxonomies")]
public class LmsTaxonomies : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("parent_id")] public string ParentId { get; set; }
    [Column("pc_media_id")] public string PcMediaId { get; set; }
    [Column("color")] public string Color { get; set; }
    [Column("weight")] public bool Weight { get; set; }

}
