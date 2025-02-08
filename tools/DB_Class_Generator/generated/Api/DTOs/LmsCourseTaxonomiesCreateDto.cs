using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseTaxonomiesCreateDto : IDto {
        public string CourseId { get; set; } = string.Empty;
        public string TaxonomyId { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}