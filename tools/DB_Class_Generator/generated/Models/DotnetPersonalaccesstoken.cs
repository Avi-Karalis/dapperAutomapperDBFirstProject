using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("dotnet_personalaccesstoken")]
public class DotnetPersonalaccesstoken : IEntity {
    [Column("id")] public int Id { get; set; }
    [Column("token")] public string Token { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("expires")] public DateTime Expires { get; set; }
    [Column("userId")] public int UserId { get; set; }

}
