using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvSessionsCreateDto : IDto {
        public string Sid { get; set; } = string.Empty;
        public DateTime Expired { get; set; } = null;
        public string Sess { get; set; } = string.Empty;
    }
}