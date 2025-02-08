using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsChatCreateDto : IDto {
        public string AccountId { get; set; } = string.Empty;
        public string TopicId { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public DateTime Date { get; set; } = null;
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
        public ulong 1Id { get; set; }
    }
}