using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("test_redis_messages")]
public class TestRedisMessages : IEntity {
    [Column("id")] public int Id { get; set; }
    [Column("username")] public string Username { get; set; }
    [Column("userId")] public string UserId { get; set; }
    [Column("timestamp")] public ulong Timestamp { get; set; }
    [Column("message")] public string Message { get; set; }
    [Column("room")] public string Room { get; set; }

}
