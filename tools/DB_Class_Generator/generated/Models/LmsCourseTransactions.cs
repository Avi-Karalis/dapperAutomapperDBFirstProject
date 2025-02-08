using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_course_transactions")]
public class LmsCourseTransactions : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("section_content_id")] public string SectionContentId { get; set; }
    [Column("course_subscription_id")] public string CourseSubscriptionId { get; set; }
    [Column("scorm_bookmark")] public string ScormBookmark { get; set; }
    [Column("scorm_progress")] public string ScormProgress { get; set; }

}
