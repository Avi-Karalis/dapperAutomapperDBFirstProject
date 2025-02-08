using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CompaniesDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}