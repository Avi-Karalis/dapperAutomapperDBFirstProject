using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LanguagesExtRepository : GenericRepository<LanguagesExt>, ILanguagesExtRepository {
        public LanguagesExtRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}