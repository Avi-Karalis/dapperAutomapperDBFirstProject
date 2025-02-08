using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseTabsRepository : GenericRepository<CnvCourseTabs>, ICnvCourseTabsRepository {
        public CnvCourseTabsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}