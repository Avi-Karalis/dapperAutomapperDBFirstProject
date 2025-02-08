using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_positions")]
public class LmsPositions : IEntity {
    [Column("position_id")] public ulong PositionId { get; set; }
    [Column("position_name")] public string PositionName { get; set; }
    [Column("status")] public bool Status { get; set; }
    [Column("order")] public bool Order { get; set; }

}
