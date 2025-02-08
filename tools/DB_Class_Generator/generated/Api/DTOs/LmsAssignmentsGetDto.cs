using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsAssignmentsGetDto : IDto {
        public ulong Id { get; set; }
    }
}