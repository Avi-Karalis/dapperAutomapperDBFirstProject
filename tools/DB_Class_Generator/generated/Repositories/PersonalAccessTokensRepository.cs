using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PersonalAccessTokensRepository : GenericRepository<PersonalAccessTokens>, IPersonalAccessTokensRepository {
        public PersonalAccessTokensRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}