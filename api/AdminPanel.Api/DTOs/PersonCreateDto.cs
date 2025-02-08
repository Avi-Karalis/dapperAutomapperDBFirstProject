using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs
{
    public class PersonCreateDto:IDto
    {

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}