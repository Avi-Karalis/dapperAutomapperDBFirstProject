using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CourseTranslationsCreateDto : IDto {
        public string CourseId { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Info { get; set; } = string.Empty;
        public string Requirement { get; set; } = string.Empty;
        public string Who { get; set; } = string.Empty;
        public string What { get; set; } = string.Empty;
        public string Certificate { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}