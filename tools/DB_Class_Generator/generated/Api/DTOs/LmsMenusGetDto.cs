using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsMenusGetDto : IDto {
        public ulong Id { get; set; }
    }
}