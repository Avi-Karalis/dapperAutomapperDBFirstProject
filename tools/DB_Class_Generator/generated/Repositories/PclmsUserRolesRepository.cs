using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsUserRolesRepository : GenericRepository<PclmsUserRoles>, IPclmsUserRolesRepository {
        public PclmsUserRolesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}