using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LanguagesRepository : GenericRepository<Languages>, ILanguagesRepository {
        public LanguagesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}