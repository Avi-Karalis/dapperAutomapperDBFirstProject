using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_course_assignments")]
public class CnvCourseAssignments : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("description")] public string Description { get; set; }
    [Column("due_at")] public string DueAt { get; set; }
    [Column("unlock_at")] public string UnlockAt { get; set; }
    [Column("lock_at")] public string LockAt { get; set; }
    [Column("points_possible")] public ulong PointsPossible { get; set; }
    [Column("grading_type")] public string GradingType { get; set; }
    [Column("assignment_group_id")] public ulong AssignmentGroupId { get; set; }
    [Column("grading_standard_id")] public string GradingStandardId { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("updated_at")] public string UpdatedAt { get; set; }
    [Column("peer_reviews")] public int PeerReviews { get; set; }
    [Column("automatic_peer_reviews")] public int AutomaticPeerReviews { get; set; }
    [Column("position")] public ulong Position { get; set; }
    [Column("grade_group_students_individually")] public int GradeGroupStudentsIndividually { get; set; }
    [Column("anonymous_peer_reviews")] public int AnonymousPeerReviews { get; set; }
    [Column("group_category_id")] public string GroupCategoryId { get; set; }
    [Column("post_to_sis")] public int PostToSis { get; set; }
    [Column("moderated_grading")] public int ModeratedGrading { get; set; }
    [Column("omit_from_final_grade")] public int OmitFromFinalGrade { get; set; }
    [Column("intra_group_peer_reviews")] public int IntraGroupPeerReviews { get; set; }
    [Column("anonymous_instructor_annotations")] public int AnonymousInstructorAnnotations { get; set; }
    [Column("anonymous_grading")] public int AnonymousGrading { get; set; }
    [Column("graders_anonymous_to_graders")] public int GradersAnonymousToGraders { get; set; }
    [Column("grader_count")] public ulong GraderCount { get; set; }
    [Column("grader_comments_visible_to_graders")] public int GraderCommentsVisibleToGraders { get; set; }
    [Column("final_grader_id")] public string FinalGraderId { get; set; }
    [Column("grader_names_visible_to_final_grader")] public int GraderNamesVisibleToFinalGrader { get; set; }
    [Column("allowed_attempts")] public ulong AllowedAttempts { get; set; }
    [Column("annotatable_attachment_id")] public string AnnotatableAttachmentId { get; set; }
    [Column("hide_in_gradebook")] public int HideInGradebook { get; set; }
    [Column("secure_params")] public string SecureParams { get; set; }
    [Column("lti_context_id")] public string LtiContextId { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("submission_types__0")] public string SubmissionTypes__0 { get; set; }
    [Column("has_submitted_submissions")] public int HasSubmittedSubmissions { get; set; }
    [Column("due_date_required")] public int DueDateRequired { get; set; }
    [Column("max_name_length")] public ulong MaxNameLength { get; set; }
    [Column("in_closed_grading_period")] public int InClosedGradingPeriod { get; set; }
    [Column("graded_submissions_exist")] public int GradedSubmissionsExist { get; set; }
    [Column("is_quiz_assignment")] public int IsQuizAssignment { get; set; }
    [Column("can_duplicate")] public int CanDuplicate { get; set; }
    [Column("original_course_id")] public string OriginalCourseId { get; set; }
    [Column("original_assignment_id")] public string OriginalAssignmentId { get; set; }
    [Column("original_lti_resource_link_id")] public string OriginalLtiResourceLinkId { get; set; }
    [Column("original_assignment_name")] public string OriginalAssignmentName { get; set; }
    [Column("original_quiz_id")] public string OriginalQuizId { get; set; }
    [Column("workflow_state")] public string WorkflowState { get; set; }
    [Column("important_dates")] public int ImportantDates { get; set; }
    [Column("is_quiz_lti_assignment")] public int IsQuizLtiAssignment { get; set; }
    [Column("frozen_attributes__0")] public string FrozenAttributes__0 { get; set; }
    [Column("external_tool_tag_attributes__url")] public string ExternalToolTagAttributes_Url { get; set; }
    [Column("external_tool_tag_attributes__new_tab")] public string ExternalToolTagAttributes_NewTab { get; set; }
    [Column("external_tool_tag_attributes__external_data")] public string ExternalToolTagAttributes_ExternalData { get; set; }
    [Column("external_tool_tag_attributes__resource_link_id")] public string ExternalToolTagAttributes_ResourceLinkId { get; set; }
    [Column("external_tool_tag_attributes__resource_link_title")] public string ExternalToolTagAttributes_ResourceLinkTitle { get; set; }
    [Column("external_tool_tag_attributes__content_type")] public string ExternalToolTagAttributes_ContentType { get; set; }
    [Column("external_tool_tag_attributes__content_id")] public ulong ExternalToolTagAttributes_ContentId { get; set; }
    [Column("external_tool_tag_attributes__custom_params")] public string ExternalToolTagAttributes_CustomParams { get; set; }
    [Column("muted")] public int Muted { get; set; }
    [Column("html_url")] public string HtmlUrl { get; set; }
    [Column("has_overrides")] public int HasOverrides { get; set; }
    [Column("url")] public string Url { get; set; }
    [Column("needs_grading_count")] public ulong NeedsGradingCount { get; set; }
    [Column("sis_assignment_id")] public string SisAssignmentId { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("published")] public int Published { get; set; }
    [Column("unpublishable")] public int Unpublishable { get; set; }
    [Column("only_visible_to_overrides")] public int OnlyVisibleToOverrides { get; set; }
    [Column("visible_to_everyone")] public int VisibleToEveryone { get; set; }
    [Column("locked_for_user")] public int LockedForUser { get; set; }
    [Column("submissions_download_url")] public string SubmissionsDownloadUrl { get; set; }
    [Column("post_manually")] public int PostManually { get; set; }
    [Column("anonymize_students")] public int AnonymizeStudents { get; set; }
    [Column("require_lockdown_browser")] public int RequireLockdownBrowser { get; set; }
    [Column("restrict_quantitative_data")] public int RestrictQuantitativeData { get; set; }

}
