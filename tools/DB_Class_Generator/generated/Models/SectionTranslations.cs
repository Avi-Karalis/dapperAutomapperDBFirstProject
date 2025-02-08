using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("section_translations")]
public class SectionTranslations : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("section_id")] public string SectionId { get; set; }
    [Column("locale")] public string Locale { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("description")] public string Description { get; set; }

}
