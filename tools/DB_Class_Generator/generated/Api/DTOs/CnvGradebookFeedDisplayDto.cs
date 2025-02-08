using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvGradebookFeedDisplayDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong Id { get; set; } = 0;
        public string Body { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Grade { get; set; } = string.Empty;
        public ulong Score { get; set; } = 0;
        public string SubmittedAt { get; set; } = string.Empty;
        public ulong AssignmentId { get; set; } = 0;
        public ulong UserId { get; set; } = 0;
        public string SubmissionType { get; set; } = string.Empty;
        public string WorkflowState { get; set; } = string.Empty;
        public int GradeMatchesCurrentSubmission { get; set; } = 0;
        public string GradedAt { get; set; } = string.Empty;
        public ulong GraderId { get; set; } = 0;
        public ulong Attempt { get; set; } = 0;
        public string CachedDueDate { get; set; } = string.Empty;
        public string Excused { get; set; } = string.Empty;
        public string LatePolicyStatus { get; set; } = string.Empty;
        public string PointsDeducted { get; set; } = string.Empty;
        public string GradingPeriodId { get; set; } = string.Empty;
        public string ExtraAttempts { get; set; } = string.Empty;
        public string PostedAt { get; set; } = string.Empty;
        public int RedoRequest { get; set; } = 0;
        public string CustomGradeStatusId { get; set; } = string.Empty;
        public string Sticker { get; set; } = string.Empty;
        public int Late { get; set; } = 0;
        public int Missing { get; set; } = 0;
        public ulong SecondsLate { get; set; } = 0;
        public string EnteredGrade { get; set; } = string.Empty;
        public ulong EnteredScore { get; set; } = 0;
        public string PreviewUrl { get; set; } = string.Empty;
        public string ExternalToolUrl { get; set; } = string.Empty;
        public string Grader { get; set; } = string.Empty;
        public string AssignmentName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string CurrentGrade { get; set; } = string.Empty;
        public string CurrentGradedAt { get; set; } = string.Empty;
        public string CurrentGrader { get; set; } = string.Empty;
    }
}