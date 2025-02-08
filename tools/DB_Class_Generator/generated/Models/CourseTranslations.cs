using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("course_translations")]
public class CourseTranslations : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("locale")] public string Locale { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("info")] public string Info { get; set; }
    [Column("requirement")] public string Requirement { get; set; }
    [Column("who")] public string Who { get; set; }
    [Column("what")] public string What { get; set; }
    [Column("certificate")] public string Certificate { get; set; }

}
