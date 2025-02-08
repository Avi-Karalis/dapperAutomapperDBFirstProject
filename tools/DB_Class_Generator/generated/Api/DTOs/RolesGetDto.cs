using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class RolesGetDto : IDto {
        public ulong Id { get; set; }
    }
}