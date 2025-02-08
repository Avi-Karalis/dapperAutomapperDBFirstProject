using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsWatchdogGetDto : IDto {
        public ulong Id { get; set; }
    }
}