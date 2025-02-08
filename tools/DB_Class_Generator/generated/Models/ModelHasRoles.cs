using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("model_has_roles")]
public class ModelHasRoles : IEntity {
    [Column("role_id")] public string RoleId { get; set; }
    [Column("model_type")] public string ModelType { get; set; }
    [Column("model_id")] public string ModelId { get; set; }

}
