using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsAccountUsersRepository : GenericRepository<PclmsAccountUsers>, IPclmsAccountUsersRepository {
        public PclmsAccountUsersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}