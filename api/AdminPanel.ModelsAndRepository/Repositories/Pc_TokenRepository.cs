using AdminPanel.ModelsAndRepository.Interfaces;
using System.Data;
using AdminPanel.ModelsAndRepository.Models;
namespace AdminPanel.ModelsAndRepository.Repositories {
    public class TokenRepository : GenericRepository<Token>, ITokenRepository {

        public TokenRepository(IDbConnection dbConnection) :base(dbConnection) { }

    }
}
