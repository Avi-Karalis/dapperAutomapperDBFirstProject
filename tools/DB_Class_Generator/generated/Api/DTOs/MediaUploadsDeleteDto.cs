using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MediaUploadsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}