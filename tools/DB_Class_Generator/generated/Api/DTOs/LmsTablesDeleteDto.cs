using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsTablesDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}