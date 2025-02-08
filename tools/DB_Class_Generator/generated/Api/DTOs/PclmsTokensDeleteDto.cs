using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsTokensDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}