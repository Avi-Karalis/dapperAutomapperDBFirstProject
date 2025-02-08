using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LanguagesI18nRepository : GenericRepository<LanguagesI18n>, ILanguagesI18nRepository {
        public LanguagesI18nRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}