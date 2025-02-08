using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CourseLikesRepository : GenericRepository<CourseLikes>, ICourseLikesRepository {
        public CourseLikesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}