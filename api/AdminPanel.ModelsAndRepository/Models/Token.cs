using AdminPanel.ModelsAndRepository.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
namespace AdminPanel.ModelsAndRepository.Models {

    [Table("tokens")]
    public class Token : IEntity {
        public ulong Id { get; set; }
    
        [Column("user_id")]
        public ulong User_Id { get; set; }
    
        [Column("masq_user_id")]
        public ulong? Masq_User_Id { get; set; }
    
        [Column("clientId")]
        public string ClientId{ get; set; }
    
        [Column("expires_at")]
        public ulong Expires_At { get; set; }
    }
}