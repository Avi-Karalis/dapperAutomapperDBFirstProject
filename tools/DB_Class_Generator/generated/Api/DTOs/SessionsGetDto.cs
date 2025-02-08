using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class SessionsGetDto : IDto {
        public ulong Id { get; set; }
    }
}