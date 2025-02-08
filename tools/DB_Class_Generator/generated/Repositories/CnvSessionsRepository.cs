using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvSessionsRepository : GenericRepository<CnvSessions>, ICnvSessionsRepository {
        public CnvSessionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}