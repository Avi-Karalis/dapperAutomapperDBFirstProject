using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class TestRedisMessagesDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}