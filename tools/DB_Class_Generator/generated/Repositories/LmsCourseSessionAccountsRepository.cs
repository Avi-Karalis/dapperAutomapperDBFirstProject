using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCourseSessionAccountsRepository : GenericRepository<LmsCourseSessionAccounts>, ILmsCourseSessionAccountsRepository {
        public LmsCourseSessionAccountsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}