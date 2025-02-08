using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Service.Interfaces {
    public interface IIdentity_TokenService : ICrudService<Token>{
        public RequesterResponse getRequesterResponse(string clientId, bool dev = false);
        public Task<Token> checkToken(RequesterResponse request);
        public DateTime ConvertUnixTimestampToDateTime(ulong unixTicks);
        public ulong ConvertDateTimeToUnixTimestamp(DateTime dateTime);
    }
}
