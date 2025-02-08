using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("languages_ext")]
public class LanguagesExt : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("ico")] public string Ico { get; set; }

}
