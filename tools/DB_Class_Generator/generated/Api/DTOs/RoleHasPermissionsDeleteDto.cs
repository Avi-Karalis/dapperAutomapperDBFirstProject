using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class RoleHasPermissionsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}