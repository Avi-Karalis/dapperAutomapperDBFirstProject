using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CacheRepository : GenericRepository<Cache>, ICacheRepository {
        public CacheRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}