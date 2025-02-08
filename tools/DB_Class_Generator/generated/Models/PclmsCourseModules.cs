using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_course_modules")]
public class PclmsCourseModules : IEntity {
    [Column("id")] public ulong Id { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("parent_id")] public ulong ParentId { get; set; }
    [Column("position")] public ulong Position { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("published")] public string Published { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("unpublishable")] public string Unpublishable { get; set; }

}
