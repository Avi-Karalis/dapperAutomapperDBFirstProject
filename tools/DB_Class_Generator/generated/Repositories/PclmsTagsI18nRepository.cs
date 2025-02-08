using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsTagsI18nRepository : GenericRepository<PclmsTagsI18n>, IPclmsTagsI18nRepository {
        public PclmsTagsI18nRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}