using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("personal_access_tokens")]
public class PersonalAccessTokens : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("tokenable_type")] public string TokenableType { get; set; }
    [Column("tokenable_id")] public string TokenableId { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("token")] public string Token { get; set; }
    [Column("abilities")] public string Abilities { get; set; }
    [Column("last_used_at")] public DateTime LastUsedAt { get; set; }
    [Column("expires_at")] public DateTime ExpiresAt { get; set; }
    [Column("created_at")] public DateTime CreatedAt { get; set; }
    [Column("updated_at")] public DateTime UpdatedAt { get; set; }
    [Column("clientid")] public string Clientid { get; set; }
    [Column("meta")] public string Meta { get; set; }

}
