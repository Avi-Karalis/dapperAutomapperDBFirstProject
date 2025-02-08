using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCourseSessionsRepository : GenericRepository<LmsCourseSessions>, ILmsCourseSessionsRepository {
        public LmsCourseSessionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}