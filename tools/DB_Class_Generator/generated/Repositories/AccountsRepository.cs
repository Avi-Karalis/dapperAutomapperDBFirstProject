using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class AccountsRepository : GenericRepository<Accounts>, IAccountsRepository {
        public AccountsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}