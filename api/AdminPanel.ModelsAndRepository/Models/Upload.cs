using AdminPanel.ModelsAndRepository.Interfaces;
namespace AdminPanel.ModelsAndRepository.Models {
    [Table("dotnet_upload")]
    public class Upload:IEntity{

        public ulong Id { get; set; }
        public string FileName { get; set; } 
        public byte[] Base64Content { get; set; } 
    }
}