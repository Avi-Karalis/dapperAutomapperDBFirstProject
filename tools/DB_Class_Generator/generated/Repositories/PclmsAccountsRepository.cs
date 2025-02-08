using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsAccountsRepository : GenericRepository<PclmsAccounts>, IPclmsAccountsRepository {
        public PclmsAccountsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}