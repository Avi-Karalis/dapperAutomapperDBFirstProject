using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCoursePagesRepository : GenericRepository<CnvCoursePages>, ICnvCoursePagesRepository {
        public CnvCoursePagesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}