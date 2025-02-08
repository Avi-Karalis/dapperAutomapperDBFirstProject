using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_account_users")]
public class PclmsAccountUsers : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("account_id")] public string AccountId { get; set; }
    [Column("user_id")] public string UserId { get; set; }
    [Column("status")] public string Status { get; set; }

}
