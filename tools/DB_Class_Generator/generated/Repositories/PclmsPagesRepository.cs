using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsPagesRepository : GenericRepository<PclmsPages>, IPclmsPagesRepository {
        public PclmsPagesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}