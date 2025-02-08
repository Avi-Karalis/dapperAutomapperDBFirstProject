using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvSubAccountsRepository : GenericRepository<CnvSubAccounts>, ICnvSubAccountsRepository {
        public CnvSubAccountsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}