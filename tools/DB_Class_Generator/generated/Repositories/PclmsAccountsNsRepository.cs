using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsAccountsNsRepository : GenericRepository<PclmsAccountsNs>, IPclmsAccountsNsRepository {
        public PclmsAccountsNsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}