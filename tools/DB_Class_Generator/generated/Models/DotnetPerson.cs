using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("dotnet_person")]
public class DotnetPerson : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("email")] public string Email { get; set; }

}
