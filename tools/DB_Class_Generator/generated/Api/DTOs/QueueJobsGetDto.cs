using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class QueueJobsGetDto : IDto {
        public ulong Id { get; set; }
    }
}