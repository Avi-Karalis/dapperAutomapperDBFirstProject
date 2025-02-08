using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("sections")]
public class Sections : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("context")] public string Context { get; set; }
    [Column("position")] public string Position { get; set; }
    [Column("duration")] public string Duration { get; set; }
    [Column("created_at")] public DateTime CreatedAt { get; set; }
    [Column("updated_at")] public DateTime UpdatedAt { get; set; }
    [Column("media_id")] public string MediaId { get; set; }
    [Column("parent_id")] public string ParentId { get; set; }
    [Column("deleted_at")] public DateTime DeletedAt { get; set; }
    [Column("trainer_only")] public bool TrainerOnly { get; set; }
    [Column("start_at")] public ulong StartAt { get; set; }
    [Column("end_at")] public ulong EndAt { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("key")] public string Key { get; set; }
    [Column("url")] public string Url { get; set; }

}
