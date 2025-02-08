using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_course_sessions")]
public class LmsCourseSessions : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("start_at")] public string StartAt { get; set; }
    [Column("end_at")] public string EndAt { get; set; }
    [Column("status")] public string Status { get; set; }
    [Column("auto")] public int Auto { get; set; }

}
