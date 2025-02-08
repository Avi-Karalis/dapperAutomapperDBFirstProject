using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsCourseQuestionAnswersRepository : GenericRepository<PclmsCourseQuestionAnswers>, IPclmsCourseQuestionAnswersRepository {
        public PclmsCourseQuestionAnswersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}