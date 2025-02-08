using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class ModelHasPermissionsGetDto : IDto {
        public ulong Id { get; set; }
    }
}