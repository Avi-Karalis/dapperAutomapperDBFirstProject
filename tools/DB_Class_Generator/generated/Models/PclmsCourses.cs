using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_courses")]
public class PclmsCourses : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("account_id")] public string AccountId { get; set; }
    [Column("course_code")] public string CourseCode { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("friendly_name")] public string FriendlyName { get; set; }
    [Column("body")] public string Body { get; set; }
    [Column("cover_media_id")] public string CoverMediaId { get; set; }
    [Column("course_color")] public string CourseColor { get; set; }
    [Column("time_zone")] public string TimeZone { get; set; }
    [Column("lang")] public string Lang { get; set; }
    [Column("start_at")] public ulong StartAt { get; set; }
    [Column("start_at_text")] public string StartAtText { get; set; }
    [Column("end_at")] public ulong EndAt { get; set; }
    [Column("end_at_text")] public string EndAtText { get; set; }
    [Column("workflow_state")] public string WorkflowState { get; set; }
    [Column("sis_course_id")] public string SisCourseId { get; set; }
    [Column("sis_import_id")] public string SisImportId { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("hide_final_grades")] public ulong HideFinalGrades { get; set; }
    [Column("uuid")] public string Uuid { get; set; }
    [Column("is_public")] public ulong IsPublic { get; set; }
    [Column("restrict_enrollments_to_course_dates")] public ulong RestrictEnrollmentsToCourseDates { get; set; }
    [Column("storage_quota_mb")] public ulong StorageQuotaMb { get; set; }
    [Column("created_at")] public ulong CreatedAt { get; set; }
    [Column("created_at_text")] public string CreatedAtText { get; set; }

}
