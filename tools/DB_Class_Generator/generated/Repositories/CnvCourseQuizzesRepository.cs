using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseQuizzesRepository : GenericRepository<CnvCourseQuizzes>, ICnvCourseQuizzesRepository {
        public CnvCourseQuizzesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}