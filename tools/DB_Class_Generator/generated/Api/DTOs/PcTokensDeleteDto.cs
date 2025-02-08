using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PcTokensDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}