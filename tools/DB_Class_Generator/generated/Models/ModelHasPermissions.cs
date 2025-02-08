using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("model_has_permissions")]
public class ModelHasPermissions : IEntity {
    [Column("permission_id")] public string PermissionId { get; set; }
    [Column("model_type")] public string ModelType { get; set; }
    [Column("model_id")] public string ModelId { get; set; }

}
