using System.Numerics;
using System;
using System.Globalization;
using AdminPanel.ModelsAndRepository.Interfaces;

namespace AdminPanel.ModelsAndRepository.Models {
    public class RequesterResponse {
        public string UserEmail { get; set; }
        public BigInteger Exp { get; set; }
        public string Sub {  get; set; }
        public RequesterResponse() {
            
        }
        public RequesterResponse(string userEmail, BigInteger exp, string sub) {
            UserEmail = userEmail;
            Exp = exp;
            Sub = sub;
        }

        public RequesterResponse(string userEmail, string exp, string sub) {
            UserEmail = userEmail;
            Exp = GetTimestamp(exp);
            Sub = sub;
        }

        public RequesterResponse(string userEmail, DateTime exp, string sub) {
            UserEmail = userEmail;
            Exp = GetTimestamp(exp);
            Sub = sub;
        }

        public static string GetTimestampToString(DateTime value) {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        public static BigInteger GetTimestamp(DateTime value) {
            
            return GetTimestamp(GetTimestampToString(value));
        }

        public static BigInteger GetTimestamp(string value) {
            BigInteger.TryParse(value, out BigInteger result);
            return result;  
        }
    }
}
