using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_course_sessions_translations")]
public class LmsCourseSessionsTranslations : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("ext_id")] public string ExtId { get; set; }
    [Column("locale")] public string Locale { get; set; }
    [Column("title")] public string Title { get; set; }

}
