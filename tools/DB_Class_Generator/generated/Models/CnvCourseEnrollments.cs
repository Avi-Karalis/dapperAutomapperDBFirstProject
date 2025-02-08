using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_course_enrollments")]
public class CnvCourseEnrollments : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("user_id")] public ulong UserId { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("updated_at")] public string UpdatedAt { get; set; }
    [Column("associated_user_id")] public string AssociatedUserId { get; set; }
    [Column("start_at")] public string StartAt { get; set; }
    [Column("end_at")] public string EndAt { get; set; }
    [Column("course_section_id")] public ulong CourseSectionId { get; set; }
    [Column("root_account_id")] public ulong RootAccountId { get; set; }
    [Column("limit_privileges_to_course_section")] public int LimitPrivilegesToCourseSection { get; set; }
    [Column("enrollment_state")] public string EnrollmentState { get; set; }
    [Column("role")] public string Role { get; set; }
    [Column("role_id")] public ulong RoleId { get; set; }
    [Column("last_activity_at")] public string LastActivityAt { get; set; }
    [Column("last_attended_at")] public string LastAttendedAt { get; set; }
    [Column("total_activity_time")] public ulong TotalActivityTime { get; set; }
    [Column("sis_import_id")] public string SisImportId { get; set; }
    [Column("grades__html_url")] public string Grades_HtmlUrl { get; set; }
    [Column("grades__current_grade")] public string Grades_CurrentGrade { get; set; }
    [Column("grades__current_score")] public string Grades_CurrentScore { get; set; }
    [Column("grades__final_grade")] public string Grades_FinalGrade { get; set; }
    [Column("grades__final_score")] public string Grades_FinalScore { get; set; }
    [Column("grades__unposted_current_score")] public string Grades_UnpostedCurrentScore { get; set; }
    [Column("grades__unposted_current_grade")] public string Grades_UnpostedCurrentGrade { get; set; }
    [Column("grades__unposted_final_score")] public string Grades_UnpostedFinalScore { get; set; }
    [Column("grades__unposted_final_grade")] public string Grades_UnpostedFinalGrade { get; set; }
    [Column("sis_account_id")] public string SisAccountId { get; set; }
    [Column("sis_course_id")] public string SisCourseId { get; set; }
    [Column("course_integration_id")] public string CourseIntegrationId { get; set; }
    [Column("sis_section_id")] public string SisSectionId { get; set; }
    [Column("section_integration_id")] public string SectionIntegrationId { get; set; }
    [Column("sis_user_id")] public string SisUserId { get; set; }
    [Column("html_url")] public string HtmlUrl { get; set; }
    [Column("user__id")] public ulong User_Id { get; set; }
    [Column("user__name")] public string User_Name { get; set; }
    [Column("user__created_at")] public string User_CreatedAt { get; set; }
    [Column("user__sortable_name")] public string User_SortableName { get; set; }
    [Column("user__short_name")] public string User_ShortName { get; set; }
    [Column("user__sis_user_id")] public string User_SisUserId { get; set; }
    [Column("user__integration_id")] public string User_IntegrationId { get; set; }
    [Column("user__sis_import_id")] public string User_SisImportId { get; set; }
    [Column("user__login_id")] public string User_LoginId { get; set; }

}
