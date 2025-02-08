using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsLovsRepository : GenericRepository<LmsLovs>, ILmsLovsRepository {
        public LmsLovsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}