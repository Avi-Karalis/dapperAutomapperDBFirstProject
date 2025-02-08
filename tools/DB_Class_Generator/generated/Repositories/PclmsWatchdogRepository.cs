using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsWatchdogRepository : GenericRepository<PclmsWatchdog>, IPclmsWatchdogRepository {
        public PclmsWatchdogRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}