using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsAccountModulesRepository : GenericRepository<PclmsAccountModules>, IPclmsAccountModulesRepository {
        public PclmsAccountModulesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}