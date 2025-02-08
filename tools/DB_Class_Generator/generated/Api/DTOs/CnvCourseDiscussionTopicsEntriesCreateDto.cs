using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCourseDiscussionTopicsEntriesCreateDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong DiscussionTopic { get; set; } = 0;
        public ulong UserId { get; set; } = 0;
        public string ParentId { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public string RatingCount { get; set; } = string.Empty;
        public string RatingSum { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public ulong User_Id { get; set; } = 0;
        public string User_AnonymousId { get; set; } = string.Empty;
        public string User_DisplayName { get; set; } = string.Empty;
        public string User_AvatarImageUrl { get; set; } = string.Empty;
        public string User_HtmlUrl { get; set; } = string.Empty;
        public string User_Pronouns { get; set; } = string.Empty;
        public string ReadState { get; set; } = string.Empty;
        public int ForcedReadState { get; set; } = 0;
    }
}