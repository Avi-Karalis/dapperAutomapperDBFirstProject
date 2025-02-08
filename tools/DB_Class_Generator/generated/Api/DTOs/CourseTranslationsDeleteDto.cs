using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CourseTranslationsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}