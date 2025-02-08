using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class SessionsRepository : GenericRepository<Sessions>, ISessionsRepository {
        public SessionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}