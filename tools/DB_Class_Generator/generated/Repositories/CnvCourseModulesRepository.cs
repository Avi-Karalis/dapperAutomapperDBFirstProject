using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseModulesRepository : GenericRepository<CnvCourseModules>, ICnvCourseModulesRepository {
        public CnvCourseModulesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}