using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class DotnetUserDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}