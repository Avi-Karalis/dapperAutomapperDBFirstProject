using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsTagsRepository : GenericRepository<PclmsTags>, IPclmsTagsRepository {
        public PclmsTagsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}