using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_taxonomy_translations")]
public class LmsTaxonomyTranslations : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("taxonomy_id")] public string TaxonomyId { get; set; }
    [Column("locale")] public string Locale { get; set; }
    [Column("title")] public string Title { get; set; }

}
