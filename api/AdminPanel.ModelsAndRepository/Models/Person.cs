using AdminPanel.ModelsAndRepository.Interfaces;
namespace AdminPanel.ModelsAndRepository.Models {
    [Table("dotnet_person")]
    public class Person: IEntity {
        public ulong Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}