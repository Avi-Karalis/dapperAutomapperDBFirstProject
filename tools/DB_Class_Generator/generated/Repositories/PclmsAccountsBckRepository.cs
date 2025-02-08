using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsAccountsBckRepository : GenericRepository<PclmsAccountsBck>, IPclmsAccountsBckRepository {
        public PclmsAccountsBckRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}