using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class LmsCourseTransactionsDeleteDto : IDto {
        public ulong Id { get; set; }
    }
}