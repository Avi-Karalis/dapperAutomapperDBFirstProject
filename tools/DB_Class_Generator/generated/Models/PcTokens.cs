using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pc_tokens")]
public class PcTokens : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("user_id")] public string UserId { get; set; }
    [Column("masq_user_id")] public string MasqUserId { get; set; }
    [Column("clientId")] public string ClientId { get; set; }
    [Column("expires_at")] public string ExpiresAt { get; set; }

}
