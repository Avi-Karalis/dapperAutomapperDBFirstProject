using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsPositionsRepository : GenericRepository<LmsPositions>, ILmsPositionsRepository {
        public LmsPositionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}