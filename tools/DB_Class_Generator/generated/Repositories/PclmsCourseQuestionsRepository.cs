using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsCourseQuestionsRepository : GenericRepository<PclmsCourseQuestions>, IPclmsCourseQuestionsRepository {
        public PclmsCourseQuestionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}