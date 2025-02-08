using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvSubmissionsCreateDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong QuizId { get; set; } = 0;
        public ulong UserId { get; set; } = 0;
        public ulong SubmissionId { get; set; } = 0;
        public ulong Score { get; set; } = 0;
        public string StartedAt { get; set; } = string.Empty;
        public string EndAt { get; set; } = string.Empty;
        public string FinishedAt { get; set; } = string.Empty;
        public ulong Attempt { get; set; } = 0;
        public ulong QuizPointsPossible { get; set; } = 0;
        public ulong TimeSpent { get; set; } = 0;
        public ulong AttemptsLeft { get; set; } = 0;
        public int OverdueAndNeedsSubmission { get; set; } = 0;
    }
}