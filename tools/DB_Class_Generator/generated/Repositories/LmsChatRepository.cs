using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsChatRepository : GenericRepository<LmsChat>, ILmsChatRepository {
        public LmsChatRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}