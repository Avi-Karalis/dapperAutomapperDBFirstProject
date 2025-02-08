using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CacheDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}