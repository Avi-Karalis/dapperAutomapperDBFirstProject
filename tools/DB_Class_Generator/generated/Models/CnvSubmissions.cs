using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_submissions")]
public class CnvSubmissions : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("quiz_id")] public ulong QuizId { get; set; }
    [Column("user_id")] public ulong UserId { get; set; }
    [Column("submission_id")] public ulong SubmissionId { get; set; }
    [Column("score")] public ulong Score { get; set; }
    [Column("started_at")] public string StartedAt { get; set; }
    [Column("end_at")] public string EndAt { get; set; }
    [Column("finished_at")] public string FinishedAt { get; set; }
    [Column("attempt")] public ulong Attempt { get; set; }
    [Column("quiz_points_possible")] public ulong QuizPointsPossible { get; set; }
    [Column("time_spent")] public ulong TimeSpent { get; set; }
    [Column("attempts_left")] public ulong AttemptsLeft { get; set; }
    [Column("overdue_and_needs_submission")] public int OverdueAndNeedsSubmission { get; set; }

}
