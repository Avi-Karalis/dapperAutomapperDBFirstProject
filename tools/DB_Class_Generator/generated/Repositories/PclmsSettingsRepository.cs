using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsSettingsRepository : GenericRepository<PclmsSettings>, IPclmsSettingsRepository {
        public PclmsSettingsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}