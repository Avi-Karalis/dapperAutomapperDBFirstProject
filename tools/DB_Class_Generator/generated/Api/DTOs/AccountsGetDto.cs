using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class AccountsGetDto : IDto {
        public ulong Id { get; set; }
    }
}