using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class ModelHasPermissionsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}