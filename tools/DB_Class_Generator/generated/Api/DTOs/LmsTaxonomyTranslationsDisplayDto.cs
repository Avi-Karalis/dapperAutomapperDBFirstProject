using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsTaxonomyTranslationsDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string TaxonomyId { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public TaxonomyIdDisplayDto? TaxonomyId { get; set; }
    }
}