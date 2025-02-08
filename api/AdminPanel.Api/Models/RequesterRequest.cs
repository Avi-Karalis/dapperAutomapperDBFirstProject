using System.Numerics;
using System;
using System.Globalization;

namespace AdminPanel.Api.Models {
    public class RequesterRequest {
        public string UserEmail { get; set; }
        public ulong Exp { get; set; }
        public string Sub {  get; set; }
        public ulong? Uid {  get; set; }
        public RequesterRequest(string userEmail, DateTime exp, string sub) {
            UserEmail = userEmail;
            Exp = GetTimestamp(exp);
            Sub = sub;
        }

        public RequesterRequest(string userEmail, ulong exp, string sub) {
            UserEmail = userEmail;
            Exp = exp;
            Sub = sub;
        }

        public ulong GetTimestamp(DateTime exp) => (ulong)new DateTimeOffset(exp).ToUnixTimeSeconds();
    }
}
