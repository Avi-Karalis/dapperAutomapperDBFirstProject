using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("dotnet_user")]
public class DotnetUser : IEntity {
    [Column("id")] public int Id { get; set; }
    [Column("Username")] public string Username { get; set; }
    [Column("PasswordHash")] public string PasswordHash { get; set; }
    [Column("Email")] public string Email { get; set; }
    [Column("CreatedAt")] public DateTime CreatedAt { get; set; }
    [Column("Salt")] public string Salt { get; set; }

}
