using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CourseTranslationsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Info { get; set; } = string.Empty;
        public string Requirement { get; set; } = string.Empty;
        public string Who { get; set; } = string.Empty;
        public string What { get; set; } = string.Empty;
        public string Certificate { get; set; } = string.Empty;
        public CourseIdDisplayDto? CourseId { get; set; }
    }
}