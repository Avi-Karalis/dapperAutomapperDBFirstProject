using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CoursesRepository : GenericRepository<Courses>, ICoursesRepository {
        public CoursesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}