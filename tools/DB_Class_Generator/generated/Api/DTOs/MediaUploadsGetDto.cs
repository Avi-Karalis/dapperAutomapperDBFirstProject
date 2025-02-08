using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MediaUploadsGetDto : IDto {
        public ulong Id { get; set; }
    }
}