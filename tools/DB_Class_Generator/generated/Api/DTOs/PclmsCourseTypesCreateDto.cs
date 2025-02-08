using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsCourseTypesCreateDto : IDto {
        public string Name { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
    }
}