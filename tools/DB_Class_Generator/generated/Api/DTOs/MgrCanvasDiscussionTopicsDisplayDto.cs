using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MgrCanvasDiscussionTopicsDisplayDto : IDto {
        public int RowId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public ulong Id { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string LastReplyAt { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string DelayedPostAt { get; set; } = string.Empty;
        public string PostedAt { get; set; } = string.Empty;
        public string AssignmentId { get; set; } = string.Empty;
        public string RootTopicId { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public int PodcastHasStudentPosts { get; set; } = 0;
        public string DiscussionType { get; set; } = string.Empty;
        public string LockAt { get; set; } = string.Empty;
        public int AllowRating { get; set; } = 0;
        public int OnlyGradersCanRate { get; set; } = 0;
        public int SortByRating { get; set; } = 0;
        public int IsSectionSpecific { get; set; } = 0;
        public string AnonymousState { get; set; } = string.Empty;
        public int SummaryEnabled { get; set; } = 0;
        public string UserName { get; set; } = string.Empty;
        public ulong DiscussionSubentryCount { get; set; } = 0;
        public int Permissions_Attach { get; set; } = 0;
        public int Permissions_Update { get; set; } = 0;
        public int Permissions_Reply { get; set; } = 0;
        public int Permissions_Delete { get; set; } = 0;
        public int Permissions_ManageAssignTo { get; set; } = 0;
        public string RequireInitialPost { get; set; } = string.Empty;
        public int UserCanSeePosts { get; set; } = 0;
        public string PodcastUrl { get; set; } = string.Empty;
        public string ReadState { get; set; } = string.Empty;
        public ulong UnreadCount { get; set; } = 0;
        public int Subscribed { get; set; } = 0;
        public int Published { get; set; } = 0;
        public int CanUnpublish { get; set; } = 0;
        public int Locked { get; set; } = 0;
        public int CanLock { get; set; } = 0;
        public int CommentsDisabled { get; set; } = 0;
        public ulong Author_Id { get; set; } = 0;
        public string Author_AnonymousId { get; set; } = string.Empty;
        public string Author_DisplayName { get; set; } = string.Empty;
        public string Author_AvatarImageUrl { get; set; } = string.Empty;
        public string Author_HtmlUrl { get; set; } = string.Empty;
        public string Author_Pronouns { get; set; } = string.Empty;
        public string HtmlUrl { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public int Pinned { get; set; } = 0;
        public string GroupCategoryId { get; set; } = string.Empty;
        public int CanGroup { get; set; } = 0;
        public int LockedForUser { get; set; } = 0;
        public string Message { get; set; } = string.Empty;
        public string TodoDate { get; set; } = string.Empty;
        public int IsAnnouncement { get; set; } = 0;
    }
}