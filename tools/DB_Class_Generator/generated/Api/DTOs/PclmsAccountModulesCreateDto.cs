using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsAccountModulesCreateDto : IDto {
        public string AccountId { get; set; } = string.Empty;
        public string CourseTypeId { get; set; } = string.Empty;
    }
}