using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_course_quizzes")]
public class PclmsCourseQuizzes : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("description")] public string Description { get; set; }
    [Column("quiz_type")] public string QuizType { get; set; }
    [Column("time_limit")] public string TimeLimit { get; set; }
    [Column("show_correct_answers")] public int ShowCorrectAnswers { get; set; }
    [Column("allowed_attempts")] public ulong AllowedAttempts { get; set; }
    [Column("points_possible")] public ulong PointsPossible { get; set; }
    [Column("published")] public int Published { get; set; }
    [Column("hide_results")] public string HideResults { get; set; }
    [Column("assignment_id")] public string AssignmentId { get; set; }
    [Column("assignment_group_id")] public ulong AssignmentGroupId { get; set; }
    [Column("shuffle_questions")] public string ShuffleQuestions { get; set; }
    [Column("shuffle_answers")] public int ShuffleAnswers { get; set; }
    [Column("multiple_attempts")] public string MultipleAttempts { get; set; }

}
