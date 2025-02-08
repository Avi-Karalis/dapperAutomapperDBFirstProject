using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsAssignmentsI18nCreateDto : IDto {
        public string Locale { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}