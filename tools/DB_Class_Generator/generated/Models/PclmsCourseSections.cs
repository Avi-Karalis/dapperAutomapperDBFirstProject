using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_course_sections")]
public class PclmsCourseSections : IEntity {
    [Column("id")] public ulong Id { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("start_at")] public ulong StartAt { get; set; }
    [Column("end_at")] public ulong EndAt { get; set; }
    [Column("published")] public int Published { get; set; }
    [Column("restrict_enrollments_to_section_dates")] public int RestrictEnrollmentsToSectionDates { get; set; }

}
