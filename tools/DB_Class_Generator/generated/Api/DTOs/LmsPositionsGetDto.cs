using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsPositionsGetDto : IDto {
        public ulong Id { get; set; }
    }
}