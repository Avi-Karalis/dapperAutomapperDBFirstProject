using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class SectionContentTranslationsRepository : GenericRepository<SectionContentTranslations>, ISectionContentTranslationsRepository {
        public SectionContentTranslationsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}