using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_course_accounts")]
public class LmsCourseAccounts : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("account_id")] public string AccountId { get; set; }
    [Column("status")] public int Status { get; set; }

}
