using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvGradebookFeedRepository : GenericRepository<CnvGradebookFeed>, ICnvGradebookFeedRepository {
        public CnvGradebookFeedRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}