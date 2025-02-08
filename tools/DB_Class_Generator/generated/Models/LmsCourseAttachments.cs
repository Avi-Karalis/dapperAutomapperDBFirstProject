using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_course_attachments")]
public class LmsCourseAttachments : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("media_id")] public string MediaId { get; set; }

}
