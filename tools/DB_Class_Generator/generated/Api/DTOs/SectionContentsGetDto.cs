using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class SectionContentsGetDto : IDto {
        public ulong Id { get; set; }
    }
}