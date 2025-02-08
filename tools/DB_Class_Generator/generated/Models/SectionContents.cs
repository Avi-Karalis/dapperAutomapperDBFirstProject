using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("section_contents")]
public class SectionContents : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("section_id")] public string SectionId { get; set; }
    [Column("context")] public string Context { get; set; }
    [Column("context_id")] public string ContextId { get; set; }
    [Column("position")] public string Position { get; set; }
    [Column("created_at")] public DateTime CreatedAt { get; set; }
    [Column("updated_at")] public DateTime UpdatedAt { get; set; }
    [Column("deleted_at")] public DateTime DeletedAt { get; set; }
    [Column("tmp_id")] public int TmpId { get; set; }
    [Column("parent_id")] public string ParentId { get; set; }
    [Column("is_downloadable")] public bool IsDownloadable { get; set; }
    [Column("contentable_type")] public string ContentableType { get; set; }
    [Column("contentable_id")] public string ContentableId { get; set; }
    [Column("scorable")] public bool Scorable { get; set; }
    [Column("data")] public string Data { get; set; }

}
