using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsCourseQuizzesRepository : GenericRepository<PclmsCourseQuizzes>, IPclmsCourseQuizzesRepository {
        public PclmsCourseQuizzesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}