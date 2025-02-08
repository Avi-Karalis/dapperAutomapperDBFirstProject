using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_course_users")]
public class PclmsCourseUsers : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("account_user_id")] public string AccountUserId { get; set; }
    [Column("start_at")] public string StartAt { get; set; }
    [Column("end_at")] public string EndAt { get; set; }
    [Column("status")] public string Status { get; set; }

}
