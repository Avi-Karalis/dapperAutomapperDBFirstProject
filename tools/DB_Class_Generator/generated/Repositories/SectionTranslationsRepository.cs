using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class SectionTranslationsRepository : GenericRepository<SectionTranslations>, ISectionTranslationsRepository {
        public SectionTranslationsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}