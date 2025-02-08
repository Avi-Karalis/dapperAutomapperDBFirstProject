namespace AdminPanel.Api.DTOs{
    public class Base64FileUploadDto{
        public string FileName { get; set; }
        public byte[] Base64Content { get; set; } 
    }
}