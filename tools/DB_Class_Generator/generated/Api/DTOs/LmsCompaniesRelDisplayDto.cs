using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCompaniesRelDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string RootId { get; set; } = string.Empty;
        public string ChildId { get; set; } = string.Empty;
        public RootIdDisplayDto? RootId { get; set; }
        public ChildIdDisplayDto? ChildId { get; set; }
    }
}