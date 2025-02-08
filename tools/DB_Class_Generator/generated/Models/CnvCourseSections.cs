using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_course_sections")]
public class CnvCourseSections : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("start_at")] public string StartAt { get; set; }
    [Column("end_at")] public string EndAt { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("restrict_enrollments_to_section_dates")] public string RestrictEnrollmentsToSectionDates { get; set; }
    [Column("nonxlist_course_id")] public string NonxlistCourseId { get; set; }
    [Column("sis_section_id")] public string SisSectionId { get; set; }
    [Column("sis_course_id")] public string SisCourseId { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("sis_import_id")] public string SisImportId { get; set; }

}
