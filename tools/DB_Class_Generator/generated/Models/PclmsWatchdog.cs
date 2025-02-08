using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_watchdog")]
public class PclmsWatchdog : IEntity {
    [Column("wid")] public string Wid { get; set; }
    [Column("user_id")] public string UserId { get; set; }
    [Column("url")] public string Url { get; set; }
    [Column("method")] public string Method { get; set; }
    [Column("payload")] public string Payload { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("message")] public string Message { get; set; }

}
