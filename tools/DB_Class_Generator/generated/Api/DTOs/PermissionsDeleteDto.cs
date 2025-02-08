using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PermissionsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}