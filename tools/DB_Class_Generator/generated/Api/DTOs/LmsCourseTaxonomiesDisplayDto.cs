using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseTaxonomiesDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string TaxonomyId { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
        public CourseIdDisplayDto? CourseId { get; set; }
        public TaxonomyIdDisplayDto? TaxonomyId { get; set; }
    }
}