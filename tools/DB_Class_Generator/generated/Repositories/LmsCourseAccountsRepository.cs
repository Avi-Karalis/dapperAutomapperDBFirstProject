using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCourseAccountsRepository : GenericRepository<LmsCourseAccounts>, ILmsCourseAccountsRepository {
        public LmsCourseAccountsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}