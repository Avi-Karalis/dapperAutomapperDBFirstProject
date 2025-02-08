using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MgrCanvasCoursesTempDisplayDto : IDto {
        public string MyRowId { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string StartAt { get; set; } = string.Empty;
        public string EndAt { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
        public string WorkflowState { get; set; } = string.Empty;
    }
}