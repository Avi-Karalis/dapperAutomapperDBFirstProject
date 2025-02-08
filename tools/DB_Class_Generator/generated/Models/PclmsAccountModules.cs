using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("pclms_account_modules")]
public class PclmsAccountModules : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("account_id")] public string AccountId { get; set; }
    [Column("course_type_id")] public string CourseTypeId { get; set; }

}
