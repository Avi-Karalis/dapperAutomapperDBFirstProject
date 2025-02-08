using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CacheLocksDisplayDto : IDto {
        public string Key { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public int Expiration { get; set; } = 0;
    }
}