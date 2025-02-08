using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_lovs")]
public class LmsLovs : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("parent_id")] public string ParentId { get; set; }
    [Column("order")] public string Order { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("status")] public bool Status { get; set; }
    [Column("locale")] public string Locale { get; set; }

}
