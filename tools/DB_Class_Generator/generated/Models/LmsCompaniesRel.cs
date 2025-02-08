using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_companies_rel")]
public class LmsCompaniesRel : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("root_id")] public string RootId { get; set; }
    [Column("child_id")] public string ChildId { get; set; }

}
