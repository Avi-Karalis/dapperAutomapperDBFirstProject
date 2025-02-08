using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsSettingsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}