using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_course_modules")]
public class CnvCourseModules : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("position")] public ulong Position { get; set; }
    [Column("unlock_at")] public string UnlockAt { get; set; }
    [Column("require_sequential_progress")] public int RequireSequentialProgress { get; set; }
    [Column("publish_final_grade")] public int PublishFinalGrade { get; set; }
    [Column("published")] public int Published { get; set; }
    [Column("items_count")] public ulong ItemsCount { get; set; }
    [Column("items_url")] public string ItemsUrl { get; set; }

}
