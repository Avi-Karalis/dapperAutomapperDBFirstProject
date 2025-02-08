using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsFoldersRepository : GenericRepository<PclmsFolders>, IPclmsFoldersRepository {
        public PclmsFoldersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}