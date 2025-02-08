using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_announcements")]
public class CnvAnnouncements : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("course_id")] public ulong CourseId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("last_reply_at")] public string LastReplyAt { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("delayed_post_at")] public string DelayedPostAt { get; set; }
    [Column("posted_at")] public string PostedAt { get; set; }
    [Column("assignment_id")] public string AssignmentId { get; set; }
    [Column("root_topic_id")] public string RootTopicId { get; set; }
    [Column("position")] public ulong Position { get; set; }
    [Column("podcast_has_student_posts")] public int PodcastHasStudentPosts { get; set; }
    [Column("discussion_type")] public string DiscussionType { get; set; }
    [Column("lock_at")] public string LockAt { get; set; }
    [Column("allow_rating")] public int AllowRating { get; set; }
    [Column("only_graders_can_rate")] public int OnlyGradersCanRate { get; set; }
    [Column("sort_by_rating")] public int SortByRating { get; set; }
    [Column("is_section_specific")] public int IsSectionSpecific { get; set; }
    [Column("anonymous_state")] public string AnonymousState { get; set; }
    [Column("summary_enabled")] public int SummaryEnabled { get; set; }
    [Column("user_name")] public string UserName { get; set; }
    [Column("discussion_subentry_count")] public ulong DiscussionSubentryCount { get; set; }
    [Column("permissions__attach")] public int Permissions_Attach { get; set; }
    [Column("permissions__update")] public int Permissions_Update { get; set; }
    [Column("permissions__reply")] public int Permissions_Reply { get; set; }
    [Column("permissions__delete")] public int Permissions_Delete { get; set; }
    [Column("permissions__manage_assign_to")] public int Permissions_ManageAssignTo { get; set; }
    [Column("require_initial_post")] public string RequireInitialPost { get; set; }
    [Column("user_can_see_posts")] public int UserCanSeePosts { get; set; }
    [Column("podcast_url")] public string PodcastUrl { get; set; }
    [Column("read_state")] public string ReadState { get; set; }
    [Column("unread_count")] public ulong UnreadCount { get; set; }
    [Column("subscribed")] public int Subscribed { get; set; }
    [Column("published")] public int Published { get; set; }
    [Column("can_unpublish")] public int CanUnpublish { get; set; }
    [Column("locked")] public int Locked { get; set; }
    [Column("can_lock")] public int CanLock { get; set; }
    [Column("comments_disabled")] public int CommentsDisabled { get; set; }
    [Column("author__id")] public ulong Author_Id { get; set; }
    [Column("author__anonymous_id")] public string Author_AnonymousId { get; set; }
    [Column("author__display_name")] public string Author_DisplayName { get; set; }
    [Column("author__avatar_image_url")] public string Author_AvatarImageUrl { get; set; }
    [Column("author__html_url")] public string Author_HtmlUrl { get; set; }
    [Column("author__pronouns")] public string Author_Pronouns { get; set; }
    [Column("html_url")] public string HtmlUrl { get; set; }
    [Column("url")] public string Url { get; set; }
    [Column("pinned")] public int Pinned { get; set; }
    [Column("group_category_id")] public string GroupCategoryId { get; set; }
    [Column("can_group")] public int CanGroup { get; set; }
    [Column("context_code")] public string ContextCode { get; set; }
    [Column("ungraded_discussion_overrides")] public string UngradedDiscussionOverrides { get; set; }
    [Column("locked_for_user")] public int LockedForUser { get; set; }
    [Column("message")] public string Message { get; set; }
    [Column("subscription_hold")] public string SubscriptionHold { get; set; }
    [Column("todo_date")] public string TodoDate { get; set; }
    [Column("is_announcement")] public int IsAnnouncement { get; set; }

}
