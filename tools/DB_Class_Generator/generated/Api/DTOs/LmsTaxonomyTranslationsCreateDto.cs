using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsTaxonomyTranslationsCreateDto : IDto {
        public string TaxonomyId { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}