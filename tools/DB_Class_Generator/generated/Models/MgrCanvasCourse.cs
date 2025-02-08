using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("mgr_canvas_course")]
public class MgrCanvasCourse : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("account_id")] public ulong AccountId { get; set; }
    [Column("uuid")] public string Uuid { get; set; }
    [Column("start_at")] public string StartAt { get; set; }
    [Column("grading_standard_id")] public string GradingStandardId { get; set; }
    [Column("is_public")] public int IsPublic { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("course_code")] public string CourseCode { get; set; }
    [Column("default_view")] public string DefaultView { get; set; }
    [Column("root_account_id")] public ulong RootAccountId { get; set; }
    [Column("enrollment_term_id")] public ulong EnrollmentTermId { get; set; }
    [Column("license")] public string License { get; set; }
    [Column("grade_passback_setting")] public string GradePassbackSetting { get; set; }
    [Column("end_at")] public string EndAt { get; set; }
    [Column("public_syllabus")] public int PublicSyllabus { get; set; }
    [Column("public_syllabus_to_auth")] public int PublicSyllabusToAuth { get; set; }
    [Column("storage_quota_mb")] public ulong StorageQuotaMb { get; set; }
    [Column("is_public_to_auth_users")] public int IsPublicToAuthUsers { get; set; }
    [Column("homeroom_course")] public int HomeroomCourse { get; set; }
    [Column("course_color")] public string CourseColor { get; set; }
    [Column("friendly_name")] public string FriendlyName { get; set; }
    [Column("hide_final_grades")] public int HideFinalGrades { get; set; }
    [Column("apply_assignment_group_weights")] public int ApplyAssignmentGroupWeights { get; set; }
    [Column("calendar__ics")] public string Calendar_Ics { get; set; }
    [Column("time_zone")] public string TimeZone { get; set; }
    [Column("blueprint")] public int Blueprint { get; set; }
    [Column("template")] public int Template { get; set; }
    [Column("sis_course_id")] public string SisCourseId { get; set; }
    [Column("sis_import_id")] public string SisImportId { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("workflow_state")] public string WorkflowState { get; set; }
    [Column("restrict_enrollments_to_course_dates")] public int RestrictEnrollmentsToCourseDates { get; set; }

}
