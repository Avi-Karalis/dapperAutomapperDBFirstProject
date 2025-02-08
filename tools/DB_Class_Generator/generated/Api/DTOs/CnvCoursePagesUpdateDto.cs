using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCoursePagesUpdateDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string EditingRoles { get; set; } = string.Empty;
        public ulong PageId { get; set; } = 0;
        public int Published { get; set; } = 0;
        public int HideFromStudents { get; set; } = 0;
        public int FrontPage { get; set; } = 0;
        public string HtmlUrl { get; set; } = string.Empty;
        public string TodoDate { get; set; } = string.Empty;
        public string PublishAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public int LockedForUser { get; set; } = 0;
        public string Body { get; set; } = string.Empty;
    }
}