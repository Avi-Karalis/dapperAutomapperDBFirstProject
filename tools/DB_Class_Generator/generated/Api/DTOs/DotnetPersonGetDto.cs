using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class DotnetPersonGetDto : IDto {
        public ulong Id { get; set; }
    }
}