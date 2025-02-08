using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class NestedSetTestDisplayDto : IDto {
        public ulong Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public int ParentId { get; set; } = 0;
        public int Lft { get; set; } = 0;
        public int Rgt { get; set; } = 0;
        public int Depth { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = null;
        public DateTime UpdatedAt { get; set; } = null;
    }
}