using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCourseModulesUpdateDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public ulong Position { get; set; } = 0;
        public string UnlockAt { get; set; } = string.Empty;
        public int RequireSequentialProgress { get; set; } = 0;
        public int PublishFinalGrade { get; set; } = 0;
        public int Published { get; set; } = 0;
        public ulong ItemsCount { get; set; } = 0;
        public string ItemsUrl { get; set; } = string.Empty;
    }
}