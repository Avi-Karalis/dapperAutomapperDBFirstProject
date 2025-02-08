using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsTranslationsRepository : GenericRepository<LmsTranslations>, ILmsTranslationsRepository {
        public LmsTranslationsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}