using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class QueueJobsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}