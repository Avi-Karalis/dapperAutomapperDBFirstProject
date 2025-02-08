using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("languages")]
public class Languages : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("code")] public string Code { get; set; }
    [Column("is_content_language")] public bool IsContentLanguage { get; set; }
    [Column("is_interface_language")] public bool IsInterfaceLanguage { get; set; }

}
