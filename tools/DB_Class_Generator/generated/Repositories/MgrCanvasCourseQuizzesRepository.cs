using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasCourseQuizzesRepository : GenericRepository<MgrCanvasCourseQuizzes>, IMgrCanvasCourseQuizzesRepository {
        public MgrCanvasCourseQuizzesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}