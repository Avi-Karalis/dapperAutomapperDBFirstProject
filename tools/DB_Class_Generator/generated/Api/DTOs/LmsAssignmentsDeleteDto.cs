using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsAssignmentsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}