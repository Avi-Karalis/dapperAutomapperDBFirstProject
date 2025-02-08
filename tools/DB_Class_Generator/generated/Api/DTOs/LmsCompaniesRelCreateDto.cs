using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCompaniesRelCreateDto : IDto {
        public string RootId { get; set; } = string.Empty;
        public string ChildId { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}