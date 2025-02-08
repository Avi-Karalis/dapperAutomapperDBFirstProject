using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PermissionsGetDto : IDto {
        public ulong Id { get; set; }
    }
}