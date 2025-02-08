using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsCoursesRepository : GenericRepository<PclmsCourses>, IPclmsCoursesRepository {
        public PclmsCoursesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}