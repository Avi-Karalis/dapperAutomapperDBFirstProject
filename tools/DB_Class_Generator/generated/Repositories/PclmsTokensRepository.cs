using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsTokensRepository : GenericRepository<PclmsTokens>, IPclmsTokensRepository {
        public PclmsTokensRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}