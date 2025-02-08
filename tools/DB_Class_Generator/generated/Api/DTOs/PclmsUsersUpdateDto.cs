using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class PclmsUsersUpdateDto : IDto {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string NickName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
        public string DateFormat { get; set; } = string.Empty;
        public string SisUserId { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public string SisImportId { get; set; } = string.Empty;
        public ulong CreatedAt { get; set; } = 0;
        public string SelectedAccountId { get; set; } = string.Empty;
        public string SelectedRoleId { get; set; } = string.Empty;
        public ulong 0Id { get; set; }
    }
}