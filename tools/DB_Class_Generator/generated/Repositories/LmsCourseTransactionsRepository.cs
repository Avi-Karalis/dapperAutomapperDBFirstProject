using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCourseTransactionsRepository : GenericRepository<LmsCourseTransactions>, ILmsCourseTransactionsRepository {
        public LmsCourseTransactionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}