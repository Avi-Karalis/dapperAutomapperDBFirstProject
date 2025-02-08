using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_course_questions")]
public class PclmsCourseQuestions : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("quiz_id")] public string QuizId { get; set; }
    [Column("position")] public int Position { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("body")] public string Body { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("shuffled")] public int Shuffled { get; set; }
    [Column("feedback_neutral")] public string FeedbackNeutral { get; set; }
    [Column("feedback_correct")] public string FeedbackCorrect { get; set; }
    [Column("feedback_incorrect")] public string FeedbackIncorrect { get; set; }

}
