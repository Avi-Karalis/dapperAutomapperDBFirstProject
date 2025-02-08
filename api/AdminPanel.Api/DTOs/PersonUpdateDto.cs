using System.ComponentModel.DataAnnotations;

namespace AdminPanel.Api.DTOs
{
    public class PersonUpdateDto : IDto
    {
   
        public ulong Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
