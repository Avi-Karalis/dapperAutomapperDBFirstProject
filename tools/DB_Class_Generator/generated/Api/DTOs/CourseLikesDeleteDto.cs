using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CourseLikesDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}