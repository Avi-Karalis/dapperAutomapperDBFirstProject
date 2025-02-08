using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("mgr_canvas_courses")]
public class MgrCanvasCourses : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public int Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("account_id")] public int AccountId { get; set; }
    [Column("uuid")] public string Uuid { get; set; }
    [Column("start_at")] public string StartAt { get; set; }
    [Column("grading_standard_id")] public string GradingStandardId { get; set; }
    [Column("is_public")] public string IsPublic { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("course_code")] public string CourseCode { get; set; }
    [Column("default_view")] public string DefaultView { get; set; }
    [Column("root_account_id")] public int RootAccountId { get; set; }
    [Column("enrollment_term_id")] public int EnrollmentTermId { get; set; }
    [Column("license")] public string License { get; set; }
    [Column("grade_passback_setting")] public string GradePassbackSetting { get; set; }
    [Column("end_at")] public string EndAt { get; set; }
    [Column("public_syllabus")] public string PublicSyllabus { get; set; }
    [Column("public_syllabus_to_auth")] public string PublicSyllabusToAuth { get; set; }
    [Column("storage_quota_mb")] public int StorageQuotaMb { get; set; }
    [Column("is_public_to_auth_users")] public string IsPublicToAuthUsers { get; set; }
    [Column("homeroom_course")] public string HomeroomCourse { get; set; }
    [Column("course_color")] public string CourseColor { get; set; }
    [Column("friendly_name")] public string FriendlyName { get; set; }
    [Column("apply_assignment_group_weights")] public string ApplyAssignmentGroupWeights { get; set; }
    [Column("calendarics")] public string Calendarics { get; set; }
    [Column("time_zone")] public string TimeZone { get; set; }
    [Column("blueprint")] public string Blueprint { get; set; }
    [Column("template")] public string Template { get; set; }
    [Column("sis_course_id")] public string SisCourseId { get; set; }
    [Column("sis_import_id")] public string SisImportId { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("hide_final_grades")] public string HideFinalGrades { get; set; }
    [Column("workflow_state")] public string WorkflowState { get; set; }
    [Column("restrict_enrollments_to_course_dates")] public string RestrictEnrollmentsToCourseDates { get; set; }
    [Column("locale")] public string Locale { get; set; }
    [Column("blueprint_restrictions")] public string BlueprintRestrictions { get; set; }
    [Column("blueprint_restrictions_by_object_type")] public string BlueprintRestrictionsByObjectType { get; set; }
    [Column("course_format")] public string CourseFormat { get; set; }

}
