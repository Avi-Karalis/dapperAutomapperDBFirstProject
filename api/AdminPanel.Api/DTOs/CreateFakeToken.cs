using System.Numerics;

namespace AdminPanel.Api.DTOs {
    public class CreateFakeToken {
        public string ClientId { get; set; }
        public ulong? Uid { get; set; }
        public ulong? Expires_At { get; set; }
    }
}
