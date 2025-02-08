using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsDeletionLogsGetDto : IDto {
        public ulong Id { get; set; }
    }
}