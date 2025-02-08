using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("companies_ext")]
public class CompaniesExt : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("base_color")] public string BaseColor { get; set; }
    [Column("header_background")] public string HeaderBackground { get; set; }
    [Column("pc_media_id")] public string PcMediaId { get; set; }

}
