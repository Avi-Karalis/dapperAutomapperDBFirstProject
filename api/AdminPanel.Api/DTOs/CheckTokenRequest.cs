namespace AdminPanel.Api.DTOs {
    public class CheckTokenRequest {
        public string ClientId { get; set; }
        public bool Dev { get; set; } = false;
    }
}
