using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_assignments")]
public class LmsAssignments : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("from_id")] public string FromId { get; set; }
    [Column("to_id")] public string ToId { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("course_session_id")] public string CourseSessionId { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("status")] public int Status { get; set; }
    [Column("created_at")] public DateTime CreatedAt { get; set; }
    [Column("updated_at")] public DateTime UpdatedAt { get; set; }
    [Column("expires_at")] public DateTime ExpiresAt { get; set; }

}
