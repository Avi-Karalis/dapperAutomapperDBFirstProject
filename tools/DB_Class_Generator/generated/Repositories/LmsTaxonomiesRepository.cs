using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsTaxonomiesRepository : GenericRepository<LmsTaxonomies>, ILmsTaxonomiesRepository {
        public LmsTaxonomiesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}