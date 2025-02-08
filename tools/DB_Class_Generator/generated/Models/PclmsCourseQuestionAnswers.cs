using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_course_question_answers")]
public class PclmsCourseQuestionAnswers : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("question_id")] public string QuestionId { get; set; }
    [Column("position")] public int Position { get; set; }
    [Column("body")] public string Body { get; set; }
    [Column("comment")] public string Comment { get; set; }
    [Column("scoring_data")] public int ScoringData { get; set; }

}
