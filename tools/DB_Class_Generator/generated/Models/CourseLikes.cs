using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("course_likes")]
public class CourseLikes : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("company_user_id")] public string CompanyUserId { get; set; }
    [Column("deleted_at")] public DateTime DeletedAt { get; set; }

}
