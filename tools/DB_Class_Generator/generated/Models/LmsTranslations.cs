using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_translations")]
public class LmsTranslations : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("table_id")] public string TableId { get; set; }
    [Column("table_name")] public string TableName { get; set; }
    [Column("locale")] public string Locale { get; set; }
    [Column("title")] public string Title { get; set; }

}
