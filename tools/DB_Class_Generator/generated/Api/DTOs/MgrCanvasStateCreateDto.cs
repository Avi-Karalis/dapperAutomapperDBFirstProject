using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class MgrCanvasStateCreateDto : IDto {
        public int RowId { get; set; } = 0;
        public string Step { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
    }
}