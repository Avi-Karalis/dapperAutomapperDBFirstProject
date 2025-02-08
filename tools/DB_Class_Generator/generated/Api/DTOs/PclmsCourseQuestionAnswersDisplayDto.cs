using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsCourseQuestionAnswersDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string QuestionId { get; set; } = string.Empty;
        public int Position { get; set; } = 0;
        public string Body { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public int ScoringData { get; set; } = 0;
    }
}