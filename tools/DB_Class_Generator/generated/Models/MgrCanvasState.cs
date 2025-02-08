using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("mgr_canvas_state")]
public class MgrCanvasState : IEntity {
    [Column("row_id")] public int RowId { get; set; }
    [Column("step")] public string Step { get; set; }
    [Column("id")] public string Id { get; set; }
    [Column("status")] public bool Status { get; set; }

}
