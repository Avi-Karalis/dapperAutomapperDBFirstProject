using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_course_pages")]
public class CnvCoursePages : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("url")] public string Url { get; set; }
    [Column("editing_roles")] public string EditingRoles { get; set; }
    [Column("page_id")] public ulong PageId { get; set; }
    [Column("published")] public int Published { get; set; }
    [Column("hide_from_students")] public int HideFromStudents { get; set; }
    [Column("front_page")] public int FrontPage { get; set; }
    [Column("html_url")] public string HtmlUrl { get; set; }
    [Column("todo_date")] public string TodoDate { get; set; }
    [Column("publish_at")] public string PublishAt { get; set; }
    [Column("updated_at")] public string UpdatedAt { get; set; }
    [Column("locked_for_user")] public int LockedForUser { get; set; }
    [Column("body")] public string Body { get; set; }

}
