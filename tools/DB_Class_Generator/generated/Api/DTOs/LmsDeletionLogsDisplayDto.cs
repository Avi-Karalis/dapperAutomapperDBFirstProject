using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsDeletionLogsDisplayDto : IDto {
        public int LogId { get; set; } = 0;
        public ulong DeletedId { get; set; } = 0;
        public DateTime DeletedAt { get; set; } = null;
        public string Message { get; set; } = string.Empty;
    }
}