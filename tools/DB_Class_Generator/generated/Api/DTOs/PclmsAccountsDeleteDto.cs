using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsAccountsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}