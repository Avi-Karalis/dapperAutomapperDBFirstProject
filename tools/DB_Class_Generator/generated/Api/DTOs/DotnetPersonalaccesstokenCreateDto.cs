using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class DotnetPersonalaccesstokenCreateDto : IDto {
        public string Token { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public DateTime Expires { get; set; } = null;
        public int UserId { get; set; } = 0;
        public ulong 0Id { get; set; }
    }
}