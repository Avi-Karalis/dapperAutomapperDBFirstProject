using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CoursesGetDto : IDto {
        public ulong Id { get; set; }
    }
}