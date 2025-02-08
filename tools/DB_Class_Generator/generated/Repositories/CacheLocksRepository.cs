using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CacheLocksRepository : GenericRepository<CacheLocks>, ICacheLocksRepository {
        public CacheLocksRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}