using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class ModelHasRolesGetDto : IDto {
        public ulong Id { get; set; }
    }
}