using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("queue_jobs")]
public class QueueJobs : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("queue")] public string Queue { get; set; }
    [Column("payload")] public string Payload { get; set; }
    [Column("attempts")] public string Attempts { get; set; }
    [Column("reserved_at")] public string ReservedAt { get; set; }
    [Column("available_at")] public string AvailableAt { get; set; }
    [Column("created_at")] public string CreatedAt { get; set; }

}
