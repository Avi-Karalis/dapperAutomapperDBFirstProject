using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_sessions")]
public class CnvSessions : IEntity {
    [Column("sid")] public string Sid { get; set; }
    [Column("expired")] public DateTime Expired { get; set; }
    [Column("sess")] public string Sess { get; set; }

}
