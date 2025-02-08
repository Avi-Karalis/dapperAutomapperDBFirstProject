using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("temp_pclms_courses")]
public class TempPclmsCourses : IEntity {
    [Column("id")] public ulong Id { get; set; }
    [Column("account")] public string Account { get; set; }
    [Column("course_code")] public string CourseCode { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("friendly_name")] public string FriendlyName { get; set; }
    [Column("course_color")] public string CourseColor { get; set; }
    [Column("start_at")] public ulong StartAt { get; set; }
    [Column("end_at")] public ulong EndAt { get; set; }
    [Column("time_zone")] public string TimeZone { get; set; }
    [Column("workflow_state")] public string WorkflowState { get; set; }
    [Column("is_public")] public int IsPublic { get; set; }
    [Column("restrict_enrollments_to_course_dates")] public int RestrictEnrollmentsToCourseDates { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("hide_final_grades")] public int HideFinalGrades { get; set; }
    [Column("uuid")] public string Uuid { get; set; }
    [Column("created_at")] public ulong CreatedAt { get; set; }

}
