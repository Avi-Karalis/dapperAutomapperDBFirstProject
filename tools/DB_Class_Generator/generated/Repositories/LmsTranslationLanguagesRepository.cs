using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsTranslationLanguagesRepository : GenericRepository<LmsTranslationLanguages>, ILmsTranslationLanguagesRepository {
        public LmsTranslationLanguagesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}