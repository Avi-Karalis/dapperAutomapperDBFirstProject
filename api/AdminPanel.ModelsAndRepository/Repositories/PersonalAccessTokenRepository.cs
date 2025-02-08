using AdminPanel.ModelsAndRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PersonalAccessTokenRepository : GenericRepository<PersonalAccessToken>, IPersonalAccessTokenRepository {
        public PersonalAccessTokenRepository(IDbConnection connection) : base(connection) {
        }
    }
}
