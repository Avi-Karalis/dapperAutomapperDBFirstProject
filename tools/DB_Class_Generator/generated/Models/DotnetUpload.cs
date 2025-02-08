using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("dotnet_upload")]
public class DotnetUpload : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("Base64Content")] public string Base64Content { get; set; }
    [Column("FileName")] public string FileName { get; set; }

}
