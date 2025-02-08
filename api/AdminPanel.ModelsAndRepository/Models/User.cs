using AdminPanel.ModelsAndRepository.Interfaces;

namespace AdminPanel.ModelsAndRepository.Models {
    [Table("dotnet_user")]
    public class User:IEntity {
        public ulong Id {  get; set; }
        public string Username{ get; set; }
        public string PasswordHash{ get; set; }
        public string Email{ get; set; }
        public DateTime CreatedAt {  get; set; }= DateTime.UtcNow;
        public string Salt { get; set; }
    }
}
