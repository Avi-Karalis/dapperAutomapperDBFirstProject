using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class SessionsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}