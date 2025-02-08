using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsUsersRepository : GenericRepository<PclmsUsers>, IPclmsUsersRepository {
        public PclmsUsersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}