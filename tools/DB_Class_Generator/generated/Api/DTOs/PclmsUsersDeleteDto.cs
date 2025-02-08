using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsUsersDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}