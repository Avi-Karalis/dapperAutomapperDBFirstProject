using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseModuleItemsRepository : GenericRepository<CnvCourseModuleItems>, ICnvCourseModuleItemsRepository {
        public CnvCourseModuleItemsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}