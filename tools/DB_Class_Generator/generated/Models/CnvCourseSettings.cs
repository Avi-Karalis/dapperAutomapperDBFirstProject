using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_course_settings")]
public class CnvCourseSettings : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("allow_final_grade_override")] public int AllowFinalGradeOverride { get; set; }
    [Column("allow_student_discussion_topics")] public int AllowStudentDiscussionTopics { get; set; }
    [Column("allow_student_forum_attachments")] public int AllowStudentForumAttachments { get; set; }
    [Column("allow_student_discussion_editing")] public int AllowStudentDiscussionEditing { get; set; }
    [Column("allow_student_discussion_reporting")] public int AllowStudentDiscussionReporting { get; set; }
    [Column("allow_student_anonymous_discussion_topics")] public int AllowStudentAnonymousDiscussionTopics { get; set; }
    [Column("filter_speed_grader_by_student_group")] public int FilterSpeedGraderByStudentGroup { get; set; }
    [Column("grading_standard_enabled")] public int GradingStandardEnabled { get; set; }
    [Column("grading_standard_id")] public string GradingStandardId { get; set; }
    [Column("grade_passback_setting")] public string GradePassbackSetting { get; set; }
    [Column("allow_student_organized_groups")] public int AllowStudentOrganizedGroups { get; set; }
    [Column("hide_final_grades")] public int HideFinalGrades { get; set; }
    [Column("hide_distribution_graphs")] public int HideDistributionGraphs { get; set; }
    [Column("hide_sections_on_course_users_page")] public int HideSectionsOnCourseUsersPage { get; set; }
    [Column("lock_all_announcements")] public int LockAllAnnouncements { get; set; }
    [Column("usage_rights_required")] public int UsageRightsRequired { get; set; }
    [Column("restrict_student_past_view")] public int RestrictStudentPastView { get; set; }
    [Column("restrict_student_future_view")] public int RestrictStudentFutureView { get; set; }
    [Column("restrict_quantitative_data")] public int RestrictQuantitativeData { get; set; }
    [Column("show_announcements_on_home_page")] public int ShowAnnouncementsOnHomePage { get; set; }
    [Column("home_page_announcement_limit")] public string HomePageAnnouncementLimit { get; set; }
    [Column("syllabus_course_summary")] public int SyllabusCourseSummary { get; set; }
    [Column("homeroom_course")] public int HomeroomCourse { get; set; }
    [Column("image_url")] public string ImageUrl { get; set; }
    [Column("image_id")] public string ImageId { get; set; }
    [Column("image")] public string Image { get; set; }
    [Column("banner_image_url")] public string BannerImageUrl { get; set; }
    [Column("banner_image_id")] public string BannerImageId { get; set; }
    [Column("banner_image")] public string BannerImage { get; set; }
    [Column("course_color")] public string CourseColor { get; set; }
    [Column("friendly_name")] public string FriendlyName { get; set; }
    [Column("default_due_time")] public string DefaultDueTime { get; set; }
    [Column("conditional_release")] public int ConditionalRelease { get; set; }

}
