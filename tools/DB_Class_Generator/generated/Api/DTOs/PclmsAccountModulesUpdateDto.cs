using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsAccountModulesUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public string CourseTypeId { get; set; } = string.Empty;
    }
}