using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_tags_i18n")]
public class PclmsTagsI18n : IEntity {
    [Column("id")] public ulong Id { get; set; }
    [Column("locale")] public string Locale { get; set; }
    [Column("title")] public string Title { get; set; }

}
