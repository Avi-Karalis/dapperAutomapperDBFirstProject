using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsChatDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}