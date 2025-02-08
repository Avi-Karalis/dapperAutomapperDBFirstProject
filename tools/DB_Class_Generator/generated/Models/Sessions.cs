using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("sessions")]
public class Sessions : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("user_id")] public string UserId { get; set; }
    [Column("ip_address")] public string IpAddress { get; set; }
    [Column("user_agent")] public string UserAgent { get; set; }
    [Column("payload")] public string Payload { get; set; }
    [Column("last_activity")] public int LastActivity { get; set; }

}
