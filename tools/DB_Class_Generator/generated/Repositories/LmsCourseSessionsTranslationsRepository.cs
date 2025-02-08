using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCourseSessionsTranslationsRepository : GenericRepository<LmsCourseSessionsTranslations>, ILmsCourseSessionsTranslationsRepository {
        public LmsCourseSessionsTranslationsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}