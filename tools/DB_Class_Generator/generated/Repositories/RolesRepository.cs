using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class RolesRepository : GenericRepository<Roles>, IRolesRepository {
        public RolesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}