using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCourseSessionAccountTransactionsRepository : GenericRepository<LmsCourseSessionAccountTransactions>, ILmsCourseSessionAccountTransactionsRepository {
        public LmsCourseSessionAccountTransactionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}