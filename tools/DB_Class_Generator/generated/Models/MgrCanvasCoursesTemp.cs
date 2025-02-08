using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("mgr_canvas_courses_temp")]
public class MgrCanvasCoursesTemp : IEntity {
    [Column("my_row_id")] public string MyRowId { get; set; }
    [Column("id")] public int Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("start_at")] public string StartAt { get; set; }
    [Column("end_at")] public string EndAt { get; set; }
    [Column("time_zone")] public string TimeZone { get; set; }
    [Column("locale")] public string Locale { get; set; }
    [Column("workflow_state")] public string WorkflowState { get; set; }

}
