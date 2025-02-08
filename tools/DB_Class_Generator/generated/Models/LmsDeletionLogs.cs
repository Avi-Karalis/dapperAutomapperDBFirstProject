using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_deletion_logs")]
public class LmsDeletionLogs : IEntity {
    [Column("log_id")] public int LogId { get; set; }
    [Column("deleted_id")] public ulong DeletedId { get; set; }
    [Column("deleted_at")] public DateTime DeletedAt { get; set; }
    [Column("message")] public string Message { get; set; }

}
