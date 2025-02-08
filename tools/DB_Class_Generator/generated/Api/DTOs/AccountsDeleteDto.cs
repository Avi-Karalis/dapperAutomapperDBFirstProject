using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class AccountsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}