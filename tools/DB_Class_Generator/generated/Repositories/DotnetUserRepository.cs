using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class DotnetUserRepository : GenericRepository<DotnetUser>, IDotnetUserRepository {
        public DotnetUserRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}