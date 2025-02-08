using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_folders")]
public class PclmsFolders : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("account_id")] public string AccountId { get; set; }
    [Column("parent_id")] public string ParentId { get; set; }
    [Column("position")] public int Position { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("full_name")] public string FullName { get; set; }
    [Column("status")] public bool Status { get; set; }

}
