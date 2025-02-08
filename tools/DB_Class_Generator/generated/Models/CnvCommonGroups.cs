using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("cnv_common_groups")]
public class CnvCommonGroups : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("accountId")] public string AccountId { get; set; }
    [Column("id")] public string Id { get; set; }
    [Column("name")] public string Name { get; set; }

}
