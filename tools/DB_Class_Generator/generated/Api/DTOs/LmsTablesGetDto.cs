using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsTablesGetDto : IDto {
        public ulong Id { get; set; }
    }
}