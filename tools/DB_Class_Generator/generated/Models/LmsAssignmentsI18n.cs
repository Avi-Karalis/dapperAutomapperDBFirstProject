using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_assignments_i18n")]
public class LmsAssignmentsI18n : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("locale")] public string Locale { get; set; }
    [Column("description")] public string Description { get; set; }

}
