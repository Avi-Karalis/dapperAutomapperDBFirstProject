using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsChatDisplayDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public string TopicId { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public DateTime Date { get; set; } = null;
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public AccountIdDisplayDto? AccountId { get; set; }
        public TopicIdDisplayDto? TopicId { get; set; }
    }
}