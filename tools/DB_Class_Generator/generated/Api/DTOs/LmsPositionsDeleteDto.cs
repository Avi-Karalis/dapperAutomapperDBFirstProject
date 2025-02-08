using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsPositionsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}