using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_pages")]
public class PclmsPages : IEntity {
    [Column("id")] public ulong Id { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("url")] public string Url { get; set; }
    [Column("body")] public string Body { get; set; }
    [Column("front_page")] public ulong FrontPage { get; set; }
    [Column("published")] public ulong Published { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("updated_at")] public string UpdatedAt { get; set; }
    [Column("publish_at")] public string PublishAt { get; set; }

}
