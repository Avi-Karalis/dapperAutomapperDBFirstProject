using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsFoldersUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public string ParentId { get; set; } = string.Empty;
        public int Position { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
        public ulong 0Id { get; set; }
    }
}