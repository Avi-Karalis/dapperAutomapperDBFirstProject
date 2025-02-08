using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseSessionsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}