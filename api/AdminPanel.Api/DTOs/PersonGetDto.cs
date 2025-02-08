using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs
{
    public class PersonGetDto : IDto
    {

        public ulong Id { get; set; } 
    }
}