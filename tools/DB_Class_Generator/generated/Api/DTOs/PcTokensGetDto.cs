using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PcTokensGetDto : IDto {
        public ulong Id { get; set; }
    }
}