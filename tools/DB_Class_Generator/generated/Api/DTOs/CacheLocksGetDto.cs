using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CacheLocksGetDto : IDto {
        public ulong Id { get; set; }
    }
}