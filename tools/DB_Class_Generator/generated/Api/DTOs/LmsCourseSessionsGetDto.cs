using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseSessionsGetDto : IDto {
        public ulong Id { get; set; }
    }
}