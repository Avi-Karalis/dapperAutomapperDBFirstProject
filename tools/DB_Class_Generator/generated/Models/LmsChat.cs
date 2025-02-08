using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_chat")]
public class LmsChat : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("account_id")] public string AccountId { get; set; }
    [Column("topic_id")] public string TopicId { get; set; }
    [Column("body")] public string Body { get; set; }
    [Column("date")] public DateTime Date { get; set; }
    [Column("firstname")] public string Firstname { get; set; }
    [Column("lastname")] public string Lastname { get; set; }

}
