using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_course_session_accounts")]
public class LmsCourseSessionAccounts : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_session_id")] public string CourseSessionId { get; set; }
    [Column("status")] public int Status { get; set; }
    [Column("course_progress")] public int CourseProgress { get; set; }
    [Column("is_teacher")] public string IsTeacher { get; set; }
    [Column("data")] public string Data { get; set; }
    [Column("account_id")] public string AccountId { get; set; }

}
