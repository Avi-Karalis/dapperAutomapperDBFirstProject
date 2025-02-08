using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.ModelsAndRepository.Interfaces {
    public interface IPersonalAccessTokenRepository : IGenericRepository<PersonalAccessToken> {
        //Task AddTokenAsync(PersonalAccessToken token);
        //Task<PersonalAccessToken> GetTokenAsync(string tokenValue, PersonalAccessToken type);
        //Task RevokeTokenAsync(string tokenValue);
    }
}
