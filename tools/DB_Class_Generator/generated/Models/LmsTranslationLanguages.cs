using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_translation_languages")]
public class LmsTranslationLanguages : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("lms_translation_id")] public string LmsTranslationId { get; set; }
    [Column("locale")] public string Locale { get; set; }
    [Column("title")] public string Title { get; set; }

}
