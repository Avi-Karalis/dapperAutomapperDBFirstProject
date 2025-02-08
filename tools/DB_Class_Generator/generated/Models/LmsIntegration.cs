using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_integration")]
public class LmsIntegration : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("source")] public string Source { get; set; }
    [Column("entity")] public string Entity { get; set; }
    [Column("external_id")] public int ExternalId { get; set; }
    [Column("entity_id")] public int EntityId { get; set; }
    [Column("status")] public int Status { get; set; }

}
