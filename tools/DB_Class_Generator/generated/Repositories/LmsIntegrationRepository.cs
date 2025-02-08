using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsIntegrationRepository : GenericRepository<LmsIntegration>, ILmsIntegrationRepository {
        public LmsIntegrationRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}