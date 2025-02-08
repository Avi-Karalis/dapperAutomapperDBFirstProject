using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs
{
    public class PersonDisplayDto :IDto
    {

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}