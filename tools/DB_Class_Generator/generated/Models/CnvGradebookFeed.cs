using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_gradebook_feed")]
public class CnvGradebookFeed : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("body")] public string Body { get; set; }
    [Column("url")] public string Url { get; set; }
    [Column("grade")] public string Grade { get; set; }
    [Column("score")] public ulong Score { get; set; }
    [Column("submitted_at")] public string SubmittedAt { get; set; }
    [Column("assignment_id")] public ulong AssignmentId { get; set; }
    [Column("user_id")] public ulong UserId { get; set; }
    [Column("submission_type")] public string SubmissionType { get; set; }
    [Column("workflow_state")] public string WorkflowState { get; set; }
    [Column("grade_matches_current_submission")] public int GradeMatchesCurrentSubmission { get; set; }
    [Column("graded_at")] public string GradedAt { get; set; }
    [Column("grader_id")] public ulong GraderId { get; set; }
    [Column("attempt")] public ulong Attempt { get; set; }
    [Column("cached_due_date")] public string CachedDueDate { get; set; }
    [Column("excused")] public string Excused { get; set; }
    [Column("late_policy_status")] public string LatePolicyStatus { get; set; }
    [Column("points_deducted")] public string PointsDeducted { get; set; }
    [Column("grading_period_id")] public string GradingPeriodId { get; set; }
    [Column("extra_attempts")] public string ExtraAttempts { get; set; }
    [Column("posted_at")] public string PostedAt { get; set; }
    [Column("redo_request")] public int RedoRequest { get; set; }
    [Column("custom_grade_status_id")] public string CustomGradeStatusId { get; set; }
    [Column("sticker")] public string Sticker { get; set; }
    [Column("late")] public int Late { get; set; }
    [Column("missing")] public int Missing { get; set; }
    [Column("seconds_late")] public ulong SecondsLate { get; set; }
    [Column("entered_grade")] public string EnteredGrade { get; set; }
    [Column("entered_score")] public ulong EnteredScore { get; set; }
    [Column("preview_url")] public string PreviewUrl { get; set; }
    [Column("external_tool_url")] public string ExternalToolUrl { get; set; }
    [Column("grader")] public string Grader { get; set; }
    [Column("assignment_name")] public string AssignmentName { get; set; }
    [Column("user_name")] public string UserName { get; set; }
    [Column("current_grade")] public string CurrentGrade { get; set; }
    [Column("current_graded_at")] public string CurrentGradedAt { get; set; }
    [Column("current_grader")] public string CurrentGrader { get; set; }

}
