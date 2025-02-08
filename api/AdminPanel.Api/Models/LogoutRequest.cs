namespace AdminPanel.Api.Models {
    public class LogoutRequest {
        public PersonalAccessToken AccessToken {  get; set; }
        public PersonalAccessToken RefreshToken {  get; set; }
    }
}
