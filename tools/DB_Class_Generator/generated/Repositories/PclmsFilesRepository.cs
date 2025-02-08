using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsFilesRepository : GenericRepository<PclmsFiles>, IPclmsFilesRepository {
        public PclmsFilesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}