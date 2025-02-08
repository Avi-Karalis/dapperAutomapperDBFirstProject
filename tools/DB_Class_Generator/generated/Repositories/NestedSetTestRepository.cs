using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class NestedSetTestRepository : GenericRepository<NestedSetTest>, INestedSetTestRepository {
        public NestedSetTestRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}