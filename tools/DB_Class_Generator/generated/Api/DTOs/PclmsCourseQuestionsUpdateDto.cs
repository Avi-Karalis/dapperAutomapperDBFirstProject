using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsCourseQuestionsUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string QuizId { get; set; } = string.Empty;
        public int Position { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Shuffled { get; set; } = 0;
        public string FeedbackNeutral { get; set; } = string.Empty;
        public string FeedbackCorrect { get; set; } = string.Empty;
        public string FeedbackIncorrect { get; set; } = string.Empty;
    }
}