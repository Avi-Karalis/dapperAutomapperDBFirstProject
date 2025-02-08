using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsTablesRepository : GenericRepository<LmsTables>, ILmsTablesRepository {
        public LmsTablesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}