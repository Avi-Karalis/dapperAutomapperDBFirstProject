using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsCourseTypesUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
    }
}