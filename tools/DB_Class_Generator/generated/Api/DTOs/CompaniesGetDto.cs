using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CompaniesGetDto : IDto {
        public ulong Id { get; set; }
    }
}