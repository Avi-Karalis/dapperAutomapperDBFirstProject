using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_tokens")]
public class PclmsTokens : IEntity {
    [Column("id")] public ulong Id { get; set; }
    [Column("clientid")] public string Clientid { get; set; }
    [Column("user_id")] public ulong UserId { get; set; }
    [Column("masq_user_id")] public ulong MasqUserId { get; set; }
    [Column("session_expires_at")] public ulong SessionExpiresAt { get; set; }
    [Column("expires_at")] public ulong ExpiresAt { get; set; }
    [Column("created_at")] public ulong CreatedAt { get; set; }

}
