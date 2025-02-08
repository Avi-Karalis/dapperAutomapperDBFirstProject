using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class EventTestsUpdateDto : IDto {
        public int Id { get; set; } = 0;
        public string Data { get; set; } = string.Empty;
        public string CompanyUsersId { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}