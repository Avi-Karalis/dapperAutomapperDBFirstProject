using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class TokenService : CrudService<Token>, IIdentity_TokenService {

        public TokenService(ITokenRepository _repository) : base(_repository) { }
        public RequesterResponse getRequesterResponse(string clientId, bool dev = false) {
            if (dev == true) {
                DateTime exp = DateTime.UtcNow;
                exp.AddDays(1);
                return new RequesterResponse("aaa@bbb.ccc", exp, clientId);
            }
            return new RequesterResponse();
        }

        public async Task<Token> checkToken(RequesterResponse request) {
            QueryParameters queryParameters = new QueryParameters();
            Console.WriteLine(request.Sub);
            queryParameters.Filters.Add(new Filter { Field = "clientId", Value = request.Sub, ConstraintOperator = "=" });
            Token token = (await ListAsync(queryParameters)).FirstOrDefault();

            if (token != null) {
                DateTime expiryDateTime = ConvertUnixTimestampToDateTime(token.Expires_At); // FIXED method name
                DateTime nowUtc = DateTime.UtcNow; // Ensure UTC comparison

                Console.WriteLine($"Expiry DateTime: {expiryDateTime} (UTC)");
                Console.WriteLine($"Current DateTime: {nowUtc} (UTC)");

                if (expiryDateTime > nowUtc) {
                    Console.WriteLine("Not expired");
                    return token;
                } else {
                    token.Expires_At = ConvertDateTimeToUnixTimestamp(nowUtc.AddMinutes(20)); // Fix: Use Unix Timestamp
                    Token updated = await UpdateAsync(token);
                    Console.WriteLine("Expired and Updated");
                    return updated;
                }
            }

            throw new Exception("LOGIN");
        }
        
        public DateTime ConvertUnixTimestampToDateTime(ulong unixTicks) =>
            // UNIX epoch starts from January 1, 1970, 00:00:00 UTC
            DateTimeOffset.FromUnixTimeSeconds((long)unixTicks).UtcDateTime;
        
        public ulong ConvertDateTimeToUnixTimestamp(DateTime dateTime) {
            return (ulong) new DateTimeOffset(dateTime).ToUnixTimeSeconds();
        }

        private ulong addOneDayAnd20Minutes() {
            DateTime time = DateTime.UtcNow.AddDays(1).AddMinutes(20);
            return ConvertDateTimeToUnixTimestamp(time);
        }


        public ulong Requester () => addOneDayAnd20Minutes();
    }
}
