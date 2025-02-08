using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class SectionsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}