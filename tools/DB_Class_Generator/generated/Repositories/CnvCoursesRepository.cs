using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCoursesRepository : GenericRepository<CnvCourses>, ICnvCoursesRepository {
        public CnvCoursesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}