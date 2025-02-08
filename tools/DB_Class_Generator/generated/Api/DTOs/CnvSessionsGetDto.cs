using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvSessionsGetDto : IDto {
        public ulong Id { get; set; }
    }
}