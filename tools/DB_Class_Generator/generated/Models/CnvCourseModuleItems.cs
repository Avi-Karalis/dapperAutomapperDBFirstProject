using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_course_module_items")]
public class CnvCourseModuleItems : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("position")] public ulong Position { get; set; }
    [Column("indent")] public ulong Indent { get; set; }
    [Column("quiz_lti")] public int QuizLti { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("module_id")] public ulong ModuleId { get; set; }
    [Column("html_url")] public string HtmlUrl { get; set; }
    [Column("page_url")] public string PageUrl { get; set; }
    [Column("publish_at")] public string PublishAt { get; set; }
    [Column("url")] public string Url { get; set; }
    [Column("published")] public int Published { get; set; }
    [Column("unpublishable")] public int Unpublishable { get; set; }

}
