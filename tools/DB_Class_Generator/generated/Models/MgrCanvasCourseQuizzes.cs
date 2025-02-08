using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("mgr_canvas_course_quizzes")]
public class MgrCanvasCourseQuizzes : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("html_url")] public string HtmlUrl { get; set; }
    [Column("mobile_url")] public string MobileUrl { get; set; }
    [Column("description")] public string Description { get; set; }
    [Column("quiz_type")] public string QuizType { get; set; }
    [Column("time_limit")] public string TimeLimit { get; set; }
    [Column("timer_autosubmit_disabled")] public int TimerAutosubmitDisabled { get; set; }
    [Column("shuffle_answers")] public int ShuffleAnswers { get; set; }
    [Column("show_correct_answers")] public int ShowCorrectAnswers { get; set; }
    [Column("scoring_policy")] public string ScoringPolicy { get; set; }
    [Column("allowed_attempts")] public ulong AllowedAttempts { get; set; }
    [Column("one_question_at_a_time")] public int OneQuestionAtATime { get; set; }
    [Column("question_count")] public ulong QuestionCount { get; set; }
    [Column("points_possible")] public ulong PointsPossible { get; set; }
    [Column("cant_go_back")] public int CantGoBack { get; set; }
    [Column("access_code")] public string AccessCode { get; set; }
    [Column("ip_filter")] public string IpFilter { get; set; }
    [Column("due_at")] public string DueAt { get; set; }
    [Column("lock_at")] public string LockAt { get; set; }
    [Column("unlock_at")] public string UnlockAt { get; set; }
    [Column("published")] public int Published { get; set; }
    [Column("unpublishable")] public int Unpublishable { get; set; }
    [Column("locked_for_user")] public int LockedForUser { get; set; }
    [Column("lock_info__missing_permission")] public string LockInfo_MissingPermission { get; set; }
    [Column("lock_info__asset_string")] public string LockInfo_AssetString { get; set; }
    [Column("lock_explanation")] public string LockExplanation { get; set; }
    [Column("hide_results")] public string HideResults { get; set; }
    [Column("show_correct_answers_at")] public string ShowCorrectAnswersAt { get; set; }
    [Column("hide_correct_answers_at")] public string HideCorrectAnswersAt { get; set; }
    [Column("all_dates__0__due_at")] public string AllDates__0_DueAt { get; set; }
    [Column("all_dates__0__unlock_at")] public string AllDates__0_UnlockAt { get; set; }
    [Column("all_dates__0__lock_at")] public string AllDates__0_LockAt { get; set; }
    [Column("all_dates__0__base")] public int AllDates__0_Base { get; set; }
    [Column("can_unpublish")] public int CanUnpublish { get; set; }
    [Column("can_update")] public int CanUpdate { get; set; }
    [Column("require_lockdown_browser")] public int RequireLockdownBrowser { get; set; }
    [Column("require_lockdown_browser_for_results")] public int RequireLockdownBrowserForResults { get; set; }
    [Column("require_lockdown_browser_monitor")] public int RequireLockdownBrowserMonitor { get; set; }
    [Column("lockdown_browser_monitor_data")] public string LockdownBrowserMonitorData { get; set; }
    [Column("speed_grader_url")] public string SpeedGraderUrl { get; set; }
    [Column("permissions__manage")] public int Permissions_Manage { get; set; }
    [Column("permissions__read")] public int Permissions_Read { get; set; }
    [Column("permissions__create")] public int Permissions_Create { get; set; }
    [Column("permissions__update")] public int Permissions_Update { get; set; }
    [Column("permissions__submit")] public int Permissions_Submit { get; set; }
    [Column("permissions__preview")] public int Permissions_Preview { get; set; }
    [Column("permissions__delete")] public int Permissions_Delete { get; set; }
    [Column("permissions__read_statistics")] public int Permissions_ReadStatistics { get; set; }
    [Column("permissions__grade")] public int Permissions_Grade { get; set; }
    [Column("permissions__review_grades")] public int Permissions_ReviewGrades { get; set; }
    [Column("permissions__view_answer_audits")] public int Permissions_ViewAnswerAudits { get; set; }
    [Column("permissions__manage_assign_to")] public int Permissions_ManageAssignTo { get; set; }
    [Column("quiz_reports_url")] public string QuizReportsUrl { get; set; }
    [Column("quiz_statistics_url")] public string QuizStatisticsUrl { get; set; }
    [Column("message_students_url")] public string MessageStudentsUrl { get; set; }
    [Column("section_count")] public ulong SectionCount { get; set; }
    [Column("important_dates")] public int ImportantDates { get; set; }
    [Column("quiz_submission_versions_html_url")] public string QuizSubmissionVersionsHtmlUrl { get; set; }
    [Column("assignment_id")] public string AssignmentId { get; set; }
    [Column("one_time_results")] public int OneTimeResults { get; set; }
    [Column("only_visible_to_overrides")] public int OnlyVisibleToOverrides { get; set; }
    [Column("visible_to_everyone")] public int VisibleToEveryone { get; set; }
    [Column("assignment_group_id")] public ulong AssignmentGroupId { get; set; }
    [Column("show_correct_answers_last_attempt")] public int ShowCorrectAnswersLastAttempt { get; set; }
    [Column("version_number")] public ulong VersionNumber { get; set; }
    [Column("has_access_code")] public int HasAccessCode { get; set; }
    [Column("post_to_sis")] public string PostToSis { get; set; }
    [Column("migration_id")] public string MigrationId { get; set; }
    [Column("in_paced_course")] public int InPacedCourse { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("filters")] public string Filters { get; set; }
    [Column("one_at_a_time_type")] public string OneAtATimeType { get; set; }
    [Column("allow_backtracking")] public string AllowBacktracking { get; set; }
    [Column("shuffle_questions")] public string ShuffleQuestions { get; set; }
    [Column("multiple_attempts")] public string MultipleAttempts { get; set; }
    [Column("result_view_settings")] public string ResultViewSettings { get; set; }

}
