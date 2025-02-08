using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class DotnetUploadDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Base64Content { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
    }
}