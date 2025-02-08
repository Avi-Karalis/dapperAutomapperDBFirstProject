using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("event_tests")]
public class EventTests : IEntity {
    [Column("id")] public int Id { get; set; }
    [Column("data")] public string Data { get; set; }
    [Column("company_users_id")] public string CompanyUsersId { get; set; }

}
