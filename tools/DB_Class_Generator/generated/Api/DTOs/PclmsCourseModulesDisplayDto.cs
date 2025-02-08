using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsCourseModulesDisplayDto : IDto {
        public ulong Id { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public ulong ParentId { get; set; } = 0;
        public ulong Position { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Published { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Unpublishable { get; set; } = string.Empty;
    }
}