using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class TempPclmsCoursesRepository : GenericRepository<TempPclmsCourses>, ITempPclmsCoursesRepository {
        public TempPclmsCoursesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}