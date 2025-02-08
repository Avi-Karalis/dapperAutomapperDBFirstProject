using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("mgr_canvas_discussion_entries")]
public class MgrCanvasDiscussionEntries : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("page_no")] public int PageNo { get; set; }
    [Column("id")] public ulong Id { get; set; }
    [Column("topic_id")] public ulong TopicId { get; set; }
    [Column("user_id")] public ulong UserId { get; set; }
    [Column("parent_id")] public string ParentId { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }
    [Column("updated_at")] public string UpdatedAt { get; set; }
    [Column("rating_count")] public string RatingCount { get; set; }
    [Column("rating_sum")] public string RatingSum { get; set; }
    [Column("user_name")] public string UserName { get; set; }
    [Column("message")] public string Message { get; set; }
    [Column("user__id")] public ulong User_Id { get; set; }
    [Column("user__anonymous_id")] public string User_AnonymousId { get; set; }
    [Column("user__display_name")] public string User_DisplayName { get; set; }
    [Column("user__avatar_image_url")] public string User_AvatarImageUrl { get; set; }
    [Column("user__html_url")] public string User_HtmlUrl { get; set; }
    [Column("user__pronouns")] public string User_Pronouns { get; set; }
    [Column("read_state")] public string ReadState { get; set; }
    [Column("forced_read_state")] public int ForcedReadState { get; set; }

}
