using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsWatchdogDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}