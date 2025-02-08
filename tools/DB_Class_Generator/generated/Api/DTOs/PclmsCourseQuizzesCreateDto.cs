using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsCourseQuizzesCreateDto : IDto {
        public string CourseId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string QuizType { get; set; } = string.Empty;
        public string TimeLimit { get; set; } = string.Empty;
        public int ShowCorrectAnswers { get; set; } = 0;
        public ulong AllowedAttempts { get; set; } = 0;
        public ulong PointsPossible { get; set; } = 0;
        public int Published { get; set; } = 0;
        public string HideResults { get; set; } = string.Empty;
        public string AssignmentId { get; set; } = string.Empty;
        public ulong AssignmentGroupId { get; set; } = 0;
        public string ShuffleQuestions { get; set; } = string.Empty;
        public int ShuffleAnswers { get; set; } = 0;
        public string MultipleAttempts { get; set; } = string.Empty;
    }
}