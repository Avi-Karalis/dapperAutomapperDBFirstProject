using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CourseTranslationsGetDto : IDto {
        public ulong Id { get; set; }
    }
}