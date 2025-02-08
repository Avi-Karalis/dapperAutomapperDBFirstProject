using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CompanyUsersGetDto : IDto {
        public ulong Id { get; set; }
    }
}