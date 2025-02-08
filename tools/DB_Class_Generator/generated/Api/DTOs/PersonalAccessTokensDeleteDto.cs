using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PersonalAccessTokensDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}