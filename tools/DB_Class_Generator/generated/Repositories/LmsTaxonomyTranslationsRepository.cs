using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsTaxonomyTranslationsRepository : GenericRepository<LmsTaxonomyTranslations>, ILmsTaxonomyTranslationsRepository {
        public LmsTaxonomyTranslationsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}