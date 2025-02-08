using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PcTokensRepository : GenericRepository<PcTokens>, IPcTokensRepository {
        public PcTokensRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}