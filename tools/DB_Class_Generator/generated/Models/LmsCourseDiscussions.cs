using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_course_discussions")]
public class LmsCourseDiscussions : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("parent_id")] public string ParentId { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("account_id")] public string AccountId { get; set; }
    [Column("body")] public string Body { get; set; }
    [Column("created")] public string Created { get; set; }

}
