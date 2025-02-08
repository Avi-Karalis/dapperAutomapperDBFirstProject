using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_course_session_account_transactions")]
public class LmsCourseSessionAccountTransactions : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_session_account_id")] public string CourseSessionAccountId { get; set; }
    [Column("section_content_id")] public string SectionContentId { get; set; }
    [Column("data")] public string Data { get; set; }

}
