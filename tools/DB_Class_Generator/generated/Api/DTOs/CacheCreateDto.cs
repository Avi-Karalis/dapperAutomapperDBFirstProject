using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CacheCreateDto : IDto {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public int Expiration { get; set; } = 0;
    }
}