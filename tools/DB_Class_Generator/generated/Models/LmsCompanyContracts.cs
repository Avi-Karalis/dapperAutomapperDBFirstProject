using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_company_contracts")]
public class LmsCompanyContracts : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("company_user_id")] public string CompanyUserId { get; set; }
    [Column("taxonomy_id")] public string TaxonomyId { get; set; }
    [Column("start_at")] public DateTime StartAt { get; set; }
    [Column("end_at")] public DateTime EndAt { get; set; }
    [Column("status")] public string Status { get; set; }

}
