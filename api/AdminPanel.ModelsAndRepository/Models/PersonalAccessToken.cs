using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

[Table("dotnet_personalaccesstoken")]
public class PersonalAccessToken  : IEntity{
    public ulong Id { get; set; }
    public string Token { get; set; }
    public TokenTypeEnum Type { get; set; }
    public ulong ExpiresAt { get; set; }
    public ulong UserId { get; set; } 

}