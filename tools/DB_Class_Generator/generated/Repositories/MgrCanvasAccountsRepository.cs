using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasAccountsRepository : GenericRepository<MgrCanvasAccounts>, IMgrCanvasAccountsRepository {
        public MgrCanvasAccountsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}