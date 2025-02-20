using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MgrCanvasCourseQuizzesCreateDto : IDto {
        public int RowId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string HtmlUrl { get; set; } = string.Empty;
        public string MobileUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string QuizType { get; set; } = string.Empty;
        public string TimeLimit { get; set; } = string.Empty;
        public int TimerAutosubmitDisabled { get; set; } = 0;
        public int ShuffleAnswers { get; set; } = 0;
        public int ShowCorrectAnswers { get; set; } = 0;
        public string ScoringPolicy { get; set; } = string.Empty;
        public ulong AllowedAttempts { get; set; } = 0;
        public int OneQuestionAtATime { get; set; } = 0;
        public ulong QuestionCount { get; set; } = 0;
        public ulong PointsPossible { get; set; } = 0;
        public int CantGoBack { get; set; } = 0;
        public string AccessCode { get; set; } = string.Empty;
        public string IpFilter { get; set; } = string.Empty;
        public string DueAt { get; set; } = string.Empty;
        public string LockAt { get; set; } = string.Empty;
        public string UnlockAt { get; set; } = string.Empty;
        public int Published { get; set; } = 0;
        public int Unpublishable { get; set; } = 0;
        public int LockedForUser { get; set; } = 0;
        public string LockInfo_MissingPermission { get; set; } = string.Empty;
        public string LockInfo_AssetString { get; set; } = string.Empty;
        public string LockExplanation { get; set; } = string.Empty;
        public string HideResults { get; set; } = string.Empty;
        public string ShowCorrectAnswersAt { get; set; } = string.Empty;
        public string HideCorrectAnswersAt { get; set; } = string.Empty;
        public string AllDates__0_DueAt { get; set; } = string.Empty;
        public string AllDates__0_UnlockAt { get; set; } = string.Empty;
        public string AllDates__0_LockAt { get; set; } = string.Empty;
        public int AllDates__0_Base { get; set; } = 0;
        public int CanUnpublish { get; set; } = 0;
        public int CanUpdate { get; set; } = 0;
        public int RequireLockdownBrowser { get; set; } = 0;
        public int RequireLockdownBrowserForResults { get; set; } = 0;
        public int RequireLockdownBrowserMonitor { get; set; } = 0;
        public string LockdownBrowserMonitorData { get; set; } = string.Empty;
        public string SpeedGraderUrl { get; set; } = string.Empty;
        public int Permissions_Manage { get; set; } = 0;
        public int Permissions_Read { get; set; } = 0;
        public int Permissions_Create { get; set; } = 0;
        public int Permissions_Update { get; set; } = 0;
        public int Permissions_Submit { get; set; } = 0;
        public int Permissions_Preview { get; set; } = 0;
        public int Permissions_Delete { get; set; } = 0;
        public int Permissions_ReadStatistics { get; set; } = 0;
        public int Permissions_Grade { get; set; } = 0;
        public int Permissions_ReviewGrades { get; set; } = 0;
        public int Permissions_ViewAnswerAudits { get; set; } = 0;
        public int Permissions_ManageAssignTo { get; set; } = 0;
        public string QuizReportsUrl { get; set; } = string.Empty;
        public string QuizStatisticsUrl { get; set; } = string.Empty;
        public string MessageStudentsUrl { get; set; } = string.Empty;
        public ulong SectionCount { get; set; } = 0;
        public int ImportantDates { get; set; } = 0;
        public string QuizSubmissionVersionsHtmlUrl { get; set; } = string.Empty;
        public string AssignmentId { get; set; } = string.Empty;
        public int OneTimeResults { get; set; } = 0;
        public int OnlyVisibleToOverrides { get; set; } = 0;
        public int VisibleToEveryone { get; set; } = 0;
        public ulong AssignmentGroupId { get; set; } = 0;
        public int ShowCorrectAnswersLastAttempt { get; set; } = 0;
        public ulong VersionNumber { get; set; } = 0;
        public int HasAccessCode { get; set; } = 0;
        public string PostToSis { get; set; } = string.Empty;
        public string MigrationId { get; set; } = string.Empty;
        public int InPacedCourse { get; set; } = 0;
        public string Type { get; set; } = string.Empty;
        public string Filters { get; set; } = string.Empty;
        public string OneAtATimeType { get; set; } = string.Empty;
        public string AllowBacktracking { get; set; } = string.Empty;
        public string ShuffleQuestions { get; set; } = string.Empty;
        public string MultipleAttempts { get; set; } = string.Empty;
        public string ResultViewSettings { get; set; } = string.Empty;
    }
}