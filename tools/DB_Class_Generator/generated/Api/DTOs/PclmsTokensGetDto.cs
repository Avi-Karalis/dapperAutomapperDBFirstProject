using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsTokensGetDto : IDto {
        public ulong Id { get; set; }
    }
}