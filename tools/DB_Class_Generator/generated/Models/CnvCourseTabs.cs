using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_course_tabs")]
public class CnvCourseTabs : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public string Id { get; set; }
    [Column("html_url")] public string HtmlUrl { get; set; }
    [Column("full_url")] public string FullUrl { get; set; }
    [Column("position")] public ulong Position { get; set; }
    [Column("visibility")] public string Visibility { get; set; }
    [Column("label")] public string Label { get; set; }
    [Column("type")] public string Type { get; set; }

}
