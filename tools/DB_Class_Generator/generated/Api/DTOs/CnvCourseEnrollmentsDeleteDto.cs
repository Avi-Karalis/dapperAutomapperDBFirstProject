using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCourseEnrollmentsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}