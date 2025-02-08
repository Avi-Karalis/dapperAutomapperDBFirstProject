using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsCourseModulesRepository : GenericRepository<PclmsCourseModules>, IPclmsCourseModulesRepository {
        public PclmsCourseModulesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}