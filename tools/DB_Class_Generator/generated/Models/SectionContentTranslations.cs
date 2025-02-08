using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("section_content_translations")]
public class SectionContentTranslations : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("section_content_id")] public string SectionContentId { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("description")] public string Description { get; set; }
    [Column("locale")] public string Locale { get; set; }

}
