using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvSessionsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}